using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Successions
{
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
            lbl_sScore.Text = Game_Form.instance.gamePlayer.Score.ToString();
        }
    }
}
