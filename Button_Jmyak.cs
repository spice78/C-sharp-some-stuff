using System;
using System.Windows.Forms;

namespace Button_Jmyak
{
    public partial class Button_Jmyak : Form
    {
        public Button_Jmyak()
        {
            InitializeComponent();
        }

        private void Jmyak_il_pulsante_Click(object sender, EventArgs e)
        {
            //Put_Ur_text_here.Text = "Hello human being";//put text in label field
            if (Controllare_Box.Checked)//check the status checkBox und put text in label field
            {
                Inserite_il_vostro_testo.Text = "Checked - Controllato";
            }
            else { Inserite_il_vostro_testo.Text = "Unchecked - Non controllato"; }          
        }       

        private void Jmyak_il_pulsante_MouseClick(object sender, MouseEventArgs e)
        {
            DateTimePicker dateTimePick = new DateTimePicker();
            DateTime dt = dateTimePick.Value;
            string sDt = Convert.ToString(dt);
            MessageBox.Show(sDt);
        }

        private void controlle_CheckedChanged(object sender, EventArgs e)
        {
            Inserite_il_vostro_testo.Text = "something happens - qualcosa accade";
        }

        private void controlle_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if(controlle_list.SelectedItem != null) //if item is selected
            {
                Inserite_il_vostro_testo.Text = controlle_list.SelectedItem.ToString();
            }*/

            foreach(String str in controlle_list.CheckedItems)
            { Inserite_il_vostro_testo.Text = str; }
        }

        private void Jmyak_Due_il_pulsante_Click(object sender, EventArgs e)
        {
            for(int i = controlle_list.CheckedIndices.Count - 1; i >= 0; i--)
            {
                controlle_list.Items.RemoveAt(controlle_list.CheckedIndices[i]);
            }
        }

        private void Jmyak_Uno_il_pulsante_Click(object sender, EventArgs e)
        {
            controlle_list.Items.Add("nuovo articolo", true);
        }        
    }
}
