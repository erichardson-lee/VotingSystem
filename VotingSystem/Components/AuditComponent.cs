using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystemClasses;

namespace VotingSystem.Components
{
    public partial class AuditComponent : UserControl
    {
        Result result;

        public AuditComponent(Result result)
        {
            this.result = result;
            InitializeComponent();

            OptionLabel.Text = result.Option.Label;
            OptionCount.Text = result.Total.ToString();
        }
    }
}
