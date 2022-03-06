using Microsoft.Win32;
using PortableRegistrator.Helper;
using PortableRegistrator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortableRegistrator
{
    public partial class Form1 : Form
    {
        // PRIVATES
        private const string _configFile = "PortableRegistrator.conf";
        private Configuration _config;
        private AppType _selectedAppType;

        // CONSTRUCTOR
        public Form1()
        {
            InitializeComponent();

            SetProductVersion();
            ReadConfiguration();
            DetectPortables();
            SetProgramTypes();
            CanRegister();
            CanUnregister();
            UpdateProgramTypeInfo();
        }

        #region METHODS

        private void SetProductVersion()
        {
            var v = new Version(Application.ProductVersion);
            Text += $" v{v.Major}.{v.Minor}";
        }
        private void SetProgramTypes()
        {
            cbProgramType.Items.Clear();
            foreach (var appType in _config.AppTypes)
            {
                cbProgramType.Items.Add(appType);
            }
            // Select first item of program type if wanted
            // cbProgramType.SelectedIndex = 0;
        }
        private void UpdateProgramTypeInfo()
        {
            _selectedAppType = (AppType)cbProgramType.SelectedItem;
            if (_selectedAppType != null)
            {
                lblFileAssociations.Text = _selectedAppType.GetFileAssociations();
                lblURLAssociations.Text = _selectedAppType.GetURLAssociations();

                if (_selectedAppType.OpenParameters == null)
                    lblOpenParameters.Text = "(null)";
                else
                    lblOpenParameters.Text = _selectedAppType.OpenParameters;

                if (_selectedAppType.PropertiesParameter == null)
                    lblPropertiesParameter.Text = "(null)";
                else
                    lblPropertiesParameter.Text = _selectedAppType.PropertiesParameter;
            }
            else
            {
                lblFileAssociations.Text = "-";
                lblURLAssociations.Text = "-";
                lblOpenParameters.Text = "-";
                lblPropertiesParameter.Text = "-";
            }
        }
        private void ReadConfiguration()
        {
            if (!File.Exists(_configFile))
            {
                _config = Configuration.CreateDefault();
                XMLSerializer.Serialize<Configuration>(_config, _configFile);
            }
            else
            {
                _config = XMLSerializer.Deserialize<Configuration>(_configFile);
            }
        }
        private void DetectPortables()
        {
            cbRegisteredPortables.Items.Clear();
            foreach (var portableApp in RegistryHelper.GetPortableApps())
            {
                cbRegisteredPortables.Items.Add(portableApp);
            }
        }

        private void SelectExecutable()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxPortablePath.Text = openFileDialog1.FileName;
                tbxProgramName.Text = Path.GetFileNameWithoutExtension(tbxPortablePath.Text)
                    .Replace("Portable", "").Replace("portable", "").Replace("PORTABLE", "").Trim();
            }
        }
        private void UpdateProgramName()
        {
            var programName = Path.GetFileNameWithoutExtension(tbxPortablePath.Text)
                .Replace("Portable", "").Replace("portable", "").Replace("Portable", "").Trim();
            tbxProgramName.Text = programName;
        }
        private void Reset()
        {
            tbxPortablePath.Text = null;
            cbProgramType.SelectedIndex = -1;
            tbxProgramName.Text = null;
            cbRegisteredPortables.SelectedIndex = -1;

            CanRegister();
            CanUnregister();
        }
        private void OpenConfig()
        {
            MessageBoxEx.Show(this,
                "Here you can setup the used Program Types." + Environment.NewLine + Environment.NewLine +
                "Please restart the program after changing the configuration!" + Environment.NewLine +
                "Also think about to register your Portable again." + Environment.NewLine +
                "Be very careful with the configuration, you can mess up the registry." + Environment.NewLine + Environment.NewLine +
                "If you need a fresh configuration file, just delete it and restart the tool." + Environment.NewLine + Environment.NewLine +
                "Greetings from the developer. ;)",
                "HINTS",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Process.Start(_configFile);
        }

        private void CanRegister()
        {
            if (!string.IsNullOrWhiteSpace(tbxPortablePath.Text)
                && (cbProgramType.SelectedItem != null)
                && (!string.IsNullOrWhiteSpace(tbxProgramName.Text)
               ))
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }
        private void Register()
        {
            var errors = RegistryHelper.Register(_selectedAppType, tbxPortablePath.Text, tbxProgramName.Text + " Portable");
            DetectPortables();

            if (errors.Count == 0)
            {
                MessageBoxEx.Show(this,
                    $"{tbxProgramName.Text} successfully registered!{Environment.NewLine}" +
                    $"Have fun and enjoy. ;)",
                    "REGISTER",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show(this,
                    $"Registration of '{tbxProgramName.Text}' unsuccessful!{Environment.NewLine}" +
                    $"Errors: {Environment.NewLine}" +
                    $"{string.Join(Environment.NewLine, errors.ToArray())}",
                    "REGISTER",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void CanUnregister()
        {
            if (cbRegisteredPortables.SelectedIndex == -1)
            {
                btnUnregister.Enabled = false;
            }
            else
            {
                btnUnregister.Enabled = true;
            }
        }
        private void Unregister()
        {
            var errors = RegistryHelper.Unregister(cbRegisteredPortables.Text);
            DetectPortables();

            if (errors.Count == 0)
            {
                MessageBoxEx.Show(this,
                    $"{tbxProgramName.Text} got successfully unregistered.",
                    "UNREGISTER",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show(this,
                    $"Deleting registration of '{tbxProgramName.Text}' unsuccessful. See Errors: {Environment.NewLine}" +
                    $"{string.Join(Environment.NewLine, errors.ToArray())}",
                    "UNREGISTER",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion

        #region EVENTS

        // EVENTS - BUTTONS
        private void btnSelectExe_Click(object sender, EventArgs e)
        {
            SelectExecutable();
            CanRegister();

        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            OpenConfig();

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register();
        }
        private void btnUnregister_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBoxEx.Show(this,
                $"Are you sure to delete the registration for {Environment.NewLine}" +
                $"'{cbRegisteredPortables.Text}'?",
                "UNREGISTER",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Unregister();
            }
        }

        // EVENTS - COMBOBOXES
        private void cbProgramType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgramTypeInfo();
            CanRegister();
        }
        private void cbRegisteredPortables_SelectedIndexChanged(object sender, EventArgs e)
        {
            CanUnregister();
        }

        // EVENTS - TEXTBOXES
        private void tbxProgramName_TextChanged(object sender, EventArgs e)
        {
            CanRegister();
        }
        private void tbxPortablePath_TextChanged(object sender, EventArgs e)
        {
            UpdateProgramName();
        }

        // EVENTS - LINKLABEL
        private void llGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/sil3nc3/PortableRegistrator");
        }

        #endregion
    }
}
