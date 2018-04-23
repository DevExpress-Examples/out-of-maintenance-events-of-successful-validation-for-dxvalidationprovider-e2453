using System;
using System.Windows.Forms;
using DevExpress.XtraEditors.DXErrorProvider;

namespace ValidationProviderSuccessEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyValidationProvider prov = new MyValidationProvider();
            prov.ValidationMode = ValidationMode.Auto;
            prov.ValidationSuccessfullyComplete += OnValidationSuccessfullyComplete;

            ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmptyValidationRule.ErrorText = "Please enter some text here";
            notEmptyValidationRule.ErrorType = ErrorType.Warning;

            prov.SetValidationRule(textEdit1, notEmptyValidationRule);
            prov.SetValidationRule(textEdit2, notEmptyValidationRule);
            prov.SetValidationRule(textEdit3, notEmptyValidationRule);

            ValidateChildren();
        }

        private void OnValidationSuccessfullyComplete(object sender, EventArgs e)
        {
            simpleButton1.Enabled = true;
            simpleButton1.Focus();
        }
    }
}
