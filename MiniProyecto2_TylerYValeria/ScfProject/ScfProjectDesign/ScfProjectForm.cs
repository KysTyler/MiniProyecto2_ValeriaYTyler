using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrivialBehind;

namespace ScfProjectDesign
{
    public partial class ScfProjectForm: Form
    {
        public ScfProjectForm()
        {
            InitializeComponent();
            this.Size = new Size(403, 409);
            level_lb.Visible = false;
            description_lb.Visible = false;
            guess_tx.Visible = false;
            ingresa_lb.Visible = false;
            go_bt.Visible = false;
            intentos_lb.Visible = false;
            try1_lb.Visible = false;
            try2_lb.Visible = false;
            try3_lb.Visible = false;
            try4_lb.Visible = false;
            try5_lb.Visible = false;
            try6_lb.Visible = false;
            try7_lb.Visible = false;
            try8_lb.Visible = false;
            try9_lb.Visible = false;
            try10_lb.Visible = false;
            try11_lb.Visible = false;
            try12_lb.Visible = false;
            try13_lb.Visible = false;
            try14_lb.Visible = false;
            try15_lb.Visible = false;
            try16_lb.Visible = false;
            try17_lb.Visible = false;
            try18_lb.Visible = false;
            try19_lb.Visible = false;
            try20_lb.Visible = false;
            // boilerplate starts
            var disposer = TrivialBehinds.CreateBehind(this, new ScfProjectUi
            {
                button1 = button1,
                label1 = label1,
                guess_tx = guess_tx,
                try1_lb = try1_lb,
                try2_lb = try2_lb,
                try3_lb = try3_lb,
                try4_lb = try4_lb,
                try5_lb = try5_lb,
                try6_lb = try6_lb,
                try7_lb = try7_lb,
                try8_lb = try8_lb,
                try9_lb = try9_lb,
                try10_lb = try10_lb,
                try11_lb = try11_lb,
                try12_lb = try12_lb,
                try13_lb = try13_lb,
                try14_lb = try14_lb,
                try15_lb = try15_lb,
                try16_lb = try16_lb,
                try17_lb = try17_lb,
                try18_lb = try18_lb,
                try19_lb = try19_lb,
                try20_lb = try20_lb,
                go_bt = go_bt
            });
            this.FormClosed += (o,e) => 
                disposer.Dispose();
            // boilerplate ends

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void easy_bt_Click(object sender, EventArgs e)
        {
            this.Size = new Size(626, 409);
            //visibles en false
            title.Visible = false;
            title2.Visible = false;
            instrucciones.Visible = false;
            easy_bt.Visible = false;
            intermediate_bt.Visible = false;
            hard_bt.Visible = false;
            //visibles en true
            level_lb.Visible = true;
            description_lb.Visible = true;
            guess_tx.Visible = true;
            ingresa_lb.Visible = true;
            go_bt.Visible = true;
            intentos_lb.Visible = true;
            try1_lb.Visible = true;
            try2_lb.Visible = true;
            try3_lb.Visible = true;
            try4_lb.Visible = true;
            try5_lb.Visible = true;
            try6_lb.Visible = true;
            try7_lb.Visible = true;
            try8_lb.Visible = true;
            try9_lb.Visible = true;
            try10_lb.Visible = true;
            
            this.CenterToScreen();


        }

        private void intermediate_bt_Click(object sender, EventArgs e)
        {
            description_lb.Text = "Debes adivinar la combinación de 5 dígitos utilizando digitos del 0 al 8. Tienes 15 intentos. ";
            this.Size = new Size(626, 409);
            //visibles en false
            title.Visible = false;
            title2.Visible = false;
            instrucciones.Visible = false;
            easy_bt.Visible = false;
            intermediate_bt.Visible = false;
            hard_bt.Visible = false;
            //visibles en true
            level_lb.Visible = true;
            description_lb.Visible = true;
            guess_tx.Visible = true;
            ingresa_lb.Visible = true;
            go_bt.Visible = true;
            intentos_lb.Visible = true;
            try1_lb.Visible = true;
            try2_lb.Visible = true;
            try3_lb.Visible = true;
            try4_lb.Visible = true;
            try5_lb.Visible = true;
            try6_lb.Visible = true;
            try7_lb.Visible = true;
            try8_lb.Visible = true;
            try9_lb.Visible = true;
            try10_lb.Visible = true;
            try11_lb.Visible = true;
            try12_lb.Visible = true;
            try13_lb.Visible = true;
            try14_lb.Visible = true;
            try15_lb.Visible = true;
            this.CenterToScreen();
        }

        private void hard_bt_Click(object sender, EventArgs e)
        {
            description_lb.Text = "Debes adivinar la combinación de 6 dígitos utilizando digitos del 0 al 9. Tienes 20 intentos. ";
            this.Size = new Size(626, 409);
            //visibles en false
            title.Visible = false;
            title2.Visible = false;
            instrucciones.Visible = false;
            easy_bt.Visible = false;
            intermediate_bt.Visible = false;
            hard_bt.Visible = false;
            //visibles en true
            level_lb.Visible = true;
            description_lb.Visible = true;
            guess_tx.Visible = true;
            ingresa_lb.Visible = true;
            go_bt.Visible = true;
            intentos_lb.Visible = true;
            try1_lb.Visible = true;
            try2_lb.Visible = true;
            try3_lb.Visible = true;
            try4_lb.Visible = true;
            try5_lb.Visible = true;
            try6_lb.Visible = true;
            try7_lb.Visible = true;
            try8_lb.Visible = true;
            try9_lb.Visible = true;
            try10_lb.Visible = true;
            try11_lb.Visible = true;
            try12_lb.Visible = true;
            try13_lb.Visible = true;
            try14_lb.Visible = true;
            try15_lb.Visible = true;
            try16_lb.Visible = true;
            try17_lb.Visible = true;
            try18_lb.Visible = true;
            try19_lb.Visible = true;
            try20_lb.Visible = true;
            this.CenterToScreen();
        }
    }
}
