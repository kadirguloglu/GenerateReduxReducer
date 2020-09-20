using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateReduxReducer
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void Master_Load(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMethodName.Text) || string.IsNullOrEmpty(txtEndpoint.Text))
            {
                MessageBox.Show("Metot adı boş geçilemez");
                return;
            }
            var r = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

            string[] methodNames = r.Replace(txtMethodName.Text, " ").Split(' ');
            string upperCaseMethodName = "";
            string imports = ",";
            string reducers = "\n\n";
            string action = "\n";
            string importAction = "";
            foreach (var item in methodNames)
            {
                upperCaseMethodName += item.ToUpper(new System.Globalization.CultureInfo("en-US")) + "_";
            }

            string endpointBiggerName = txtEndpoint.Text.ToUpper(new System.Globalization.CultureInfo("en-US"));

            upperCaseMethodName = upperCaseMethodName.TrimEnd('_');
            string typeText = "\n";
            foreach (var item in new string[] { "", "_SUCCESS", "_FAIL" })
            {
                typeText += $"export const {upperCaseMethodName}{item} = \"{endpointBiggerName}/{upperCaseMethodName}/LOAD{item}\";\n";
                imports += upperCaseMethodName + item + ",\n";
            }
            typeText += $"export const {upperCaseMethodName}_URL = \"/{txtEndpoint.Text}/{txtMethodName.Text}\";\n";
            imports = imports.Trim(',');

            importAction += upperCaseMethodName + ",\n";
            importAction += upperCaseMethodName + "_URL\n";


            string propertyName = Char.ToLowerInvariant(txtMethodName.Text[0]) + txtMethodName.Text.Substring(1);

            string processType = "";
            reducers += $"case {upperCaseMethodName}{processType}:\n";
            reducers += $"return {'{'}...state, {propertyName}Loading:true,{propertyName}Result:{'{'}{'}'},{propertyName}Fail:false{'}'}\n";

            processType = "_SUCCESS";
            reducers += $"case {upperCaseMethodName}{processType}:\n";
            reducers += $"return {'{'}...state,{propertyName}Loading:false, {propertyName}Result:action.payload.data,{propertyName}Fail:false{'}'}\n";

            processType = "_FAIL";
            reducers += $"case {upperCaseMethodName}{processType}:\n";
            if (cbLogger.Checked)
            {
                reducers += @"Sentry.captureException(
                    new Error(
                      JSON.stringify({
                        case: '" + upperCaseMethodName + processType + @"',
                        error: action
                      })
                    )
                  );";
            }
            reducers += $"\nreturn {'{'}...state,{propertyName}Loading:false,{propertyName}Result:{'{'}{'}'},{propertyName}Fail:true{'}'}\n";
            rchInitialState.Text = $"{propertyName}Loading:false,\n{propertyName}Result:{'{'}{'}'},\n{propertyName}Fail:false,";
            string urlParameters = "";
            string postParameter = "";
            action += $"export function {propertyName}(";
            if (!string.IsNullOrEmpty(txtParam1.Text))
            {
                action += $"{txtParam1.Text},";
                urlParameters += "/${" + txtParam1.Text + "}";
                postParameter += $"{txtParam1.Text}:{txtParam1.Text},";
            }
            if (!string.IsNullOrEmpty(txtParam2.Text))
            {
                action += $"{txtParam2.Text},";
                urlParameters += "/${" + txtParam2.Text + "}";
                postParameter += $"{txtParam2.Text}:{txtParam2.Text},";
            }
            if (!string.IsNullOrEmpty(txtParam3.Text))
            {
                action += $"{txtParam3.Text},";
                urlParameters += "/${" + txtParam3.Text + "}";
                postParameter += $"{txtParam3.Text}:{txtParam3.Text},";
            }
            if (!string.IsNullOrEmpty(txtParam4.Text))
            {
                action += $"{txtParam4.Text},";
                urlParameters += "/${" + txtParam4.Text + "}";
                postParameter += $"{txtParam4.Text}:{txtParam4.Text},";
            }
            action = action.TrimEnd(',');
            postParameter = postParameter.TrimEnd(',');
            action += ") {\n";
            action += "return {\n";
            action += $"type: {upperCaseMethodName},\n";
            action += "payload: {\n";
            action += "request: {\n";
            switch (cmbType.Text)
            {
                case "GET":
                    action += $"url: `${"{"}{upperCaseMethodName}_URL{"}"}{urlParameters}`\n";
                    break;
                case "POST":
                    action += $"url: `${"{"}{upperCaseMethodName}_URL{"}"}`,\n";
                    action += $"method: 'POST',\n";
                    action += $"data:{"{"}{postParameter}{"}"}";
                    break;
                case "DELETE":
                    action += $"url: `${"{"}{upperCaseMethodName}_URL{"}"}{urlParameters}`,\n";
                    action += $"method: 'DELETE',\n";
                    break;
                case "PUT":
                    action += $"url: `${"{"}{upperCaseMethodName}_URL{"}"}`,\n";
                    action += $"method: 'PUT',\n";
                    action += $"data:{"{"}{postParameter}{"}"}";
                    break;
            }
            action += "}\n";
            action += "}\n";
            action += "};\n";
            action += "}";

            rchTypes.Text = typeText;
            rchImport.Text = imports;
            rchReducers.Text = reducers;
            rchActions.Text = action;
            rchImportAction.Text = importAction;
        }
    }
}
