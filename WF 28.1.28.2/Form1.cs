using System;
using System.Data.Common;
using System.DirectoryServices;
using System.Drawing.Text;
using System.Text;

namespace WF_28._1._28._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random random = new Random();

            int name = random.Next(1, 5);
            switch (name)
            {
                case 1:
                    lbRes.Text = "Успех - это способность идти от одной неудачи к другой, не потеряв энтузиазма. - Уинстон Черчилль"; break;
                case 2:
                    lbRes.Text = "Лучший способ предсказать будущее - создать его. - Питер Друкер"; break;
                case 3:
                    lbRes.Text = "Будь изменением, которое ты хочешь видеть в мире. - Махатма Ганди"; break;
                case 4:
                    lbRes.Text = "Сложности - это возможности, скрытые в обманчивой обертке. - Альберт Эйнштейн "; break;
                case 5:
                    lbRes.Text = "Не важно, сколько раз вы падаете - важно, сколько раз вы поднимаетесь. - Мэрилин Монро"; break;

            }

        }






        private void btgen_Click(object sender, EventArgs e)
        {

            string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            int length = random.Next(5, 20);

            for (int i = 0; i < length; i++)
            {
                password.Append(validChars[random.Next(validChars.Length)]);
            }
            lblog.Items.Add(tbusserlog.Text);
            lbpass.Items.Add(password.ToString());




        }

        private void btClear_Click(object sender, EventArgs e)
        {
            lblog.Items.Clear();
            lbpass.Items.Clear();
        }
    }
}


              
            
        
    



        
             


  





