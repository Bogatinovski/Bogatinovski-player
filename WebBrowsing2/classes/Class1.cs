using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Bogatinovski_Player
{
     
    class Class1
    {
       public static string[] input;
        public static string site = "http://bogatinovski.weebly.com/";
       /// <summary>
       /// pomaga pri odlucuvanje dali web browserot da se vrati nazad na google search ili da ostane na tekovnata strana so lyricsot
       /// Se vraka ako e smeneta pesnata ili ostanuva na istata strana ako se uste e pustena istata pesna za koja sto e namenet lyricsot
       /// </summary>
        public static bool newSong = false;

        public static string textBoxText = "";

       /// <summary>
       /// Metod za pokazuvanje na Input box
       /// </summary>
       /// <param name="title">Naslovot na boxot</param>
       /// <param name="promptText">Tekstot sto kazuva sto treba da se vnese</param>
       /// <param name="value">promenlivata (String) vo koja se smestuva vneseniot tekst</param>
       /// <returns>Vraka Dialog Result vo forma na input box</returns>
        public static DialogResult InputBox(string title, string promptText, ref string value, string inputText="")
        {
            Font font = new Font("Times New Roman", 10.0f);
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;
            form.BackColor = Color.FromArgb(180, 180, 180);
            form.BackgroundImage = Properties.Resources.Blue_matrix;
            form.BackgroundImageLayout = ImageLayout.Stretch;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonOk.FlatStyle = FlatStyle.Flat;
            buttonOk.FlatAppearance.BorderSize = 0;
            buttonOk.FlatAppearance.BorderColor = Color.White;
            buttonOk.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            buttonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 160, 160);
      
           
            // ButtonCancel design
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.FlatAppearance.BorderSize = 1;
            buttonCancel.FlatAppearance.BorderColor = Color.White;
            buttonCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            buttonCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 160, 160);
            label.BackColor = Color.Transparent;
            label.BorderStyle = BorderStyle.Fixed3D;
            label.Font = font;

            label.SetBounds(13, 18, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            textBox.Text = textBoxText;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            if (inputText.Contains(".pl"))
                 textBox.Text = inputText.Substring(0, inputText.Length-3);
            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
                return dialogResult;
            
        }
    }
}