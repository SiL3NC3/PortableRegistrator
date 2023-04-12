using PortableRegistratorCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PortableRegistrator.Controls
{
    public partial class DialogAdd : Form
    {
        public DialogAdd()
        {
            InitializeComponent();
            tbxProgramName.Focus();
            tbxOpenParameters.Text = "%1";
        }

        public AppType AppType { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;

            if (String.IsNullOrWhiteSpace(tbxProgramName.Text))
            {
                tbxProgramName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(tbxFileAssociations.Text) && String.IsNullOrWhiteSpace(tbxUrlAssociations.Text))
            {
                if (String.IsNullOrWhiteSpace(tbxFileAssociations.Text))
                {
                    tbxFileAssociations.Focus();
                }
                else if (String.IsNullOrWhiteSpace(tbxUrlAssociations.Text))
                {
                    tbxUrlAssociations.Focus();
                }
            }
            else
            {
                try
                {
                    // Clean File Extensions
                    var fileAssociations = new List<string>();
                    foreach (var line in tbxFileAssociations.Lines)
                    {
                        if (!line.StartsWith("."))
                        {
                            fileAssociations.Add($".{line}");
                        }
                        else
                        {
                            fileAssociations.Add(line);
                        }
                    }

                    var urlAssociations = new List<string>();
                    foreach (var line in tbxUrlAssociations.Lines)
                    {
                        urlAssociations.Add(line);
                    }

                    AppType = new AppType
                    {
                        Name = tbxProgramName.Text,
                        OpenParameters = $"\"{tbxOpenParameters.Text}\"",
                        PropertiesParameter = $"{tbxPropertiesParameters.Text}",
                        FileAssociations = fileAssociations,
                        URLAssociations = urlAssociations
                    };

                    DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBoxEx.Show("An unexpected Error occurred." + Environment.NewLine + "Cannot create Program-Type.");
                    DialogResult = DialogResult.None;
                }
            }
        }
    }
}
