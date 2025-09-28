using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DLL;   

namespace WDF
{
    public partial class Form1 : Form
    {
        TextBox inputBox;
        Button generateBtn;
        RichTextBox outputBox;

        public Form1()
        {
            InitializeComponent();
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = "Cosmic Desktop ✨";
            this.Width = 600;
            this.Height = 400;

            Label lbl = new Label();
            lbl.Text = "Nhập tên/chuỗi:";
            lbl.Top = 15;
            lbl.Left = 10;
            lbl.Width = 120;
            this.Controls.Add(lbl);

            inputBox = new TextBox();
            inputBox.Top = 35;
            inputBox.Left = 10;
            inputBox.Width = 200;
            this.Controls.Add(inputBox);

            generateBtn = new Button();
            generateBtn.Text = "Tạo Chỉ Số";
            generateBtn.Top = 33;
            generateBtn.Left = 420;
            generateBtn.Click += new EventHandler(OnGenerate);
            this.Controls.Add(generateBtn);

            outputBox = new RichTextBox();
            outputBox.Top = 75;
            outputBox.Left = 10;
            outputBox.Width = 560;
            outputBox.Height = 260;
            outputBox.Font = new Font("Consolas", 10);
            this.Controls.Add(outputBox);
        }

        private void OnGenerate(object sender, EventArgs e)
        {
            Class1 calc = new Class1();
            calc.Input = inputBox.Text;
            string report = calc.Caculate();

            outputBox.Text = report;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
