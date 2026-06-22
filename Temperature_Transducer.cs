using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TemperatureTransducer
{
    public partial class Temperature_Transducer : Form
    {
        bool F = false;
        bool C = true;
        bool K = false;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Temperature_Transducer()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_C.BackColor = Color.Turquoise;
            btn_C.ForeColor = Color.Black;

            panel1.MouseDown += new MouseEventHandler(Form_MouseDown);
            panel1.MouseMove += new MouseEventHandler(Form_MouseMove);
            panel1.MouseUp += new MouseEventHandler(Form_MouseUp);
        }
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txt_Degree_TextChanged(object sender, EventArgs e)
        {
            string currentText = txt_Degree.Text;
            if (!IsValidInput(currentText))
            {
                txt_Degree.Undo();
            }

            if (!string.IsNullOrEmpty(txt_Degree.Text))
            {
                lbl_Degree.Visible = false;
            }
            else
            {
                lbl_Degree.Visible = true;
            }
            if (F)
            {
                if (!string.IsNullOrEmpty(txt_Degree.Text))
                {
                    txt_F.Text = txt_Degree.Text;
                    try
                    {
                        decimal cDegree = (Convert.ToDecimal(txt_Degree.Text) - 32) / 1.8M;
                        txt_C.Text = cDegree.ToString();
                        decimal kDegree = cDegree + 273.15M;
                        txt_K.Text = kDegree.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("System Error : " + ex.Message, "Temperature Transducer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txt_C.Text = string.Empty;
                    txt_F.Text = string.Empty;
                    txt_K.Text = string.Empty;
                }
            }
            if (C)
            {
                if (!string.IsNullOrEmpty(txt_Degree.Text))
                {
                    txt_C.Text = txt_Degree.Text;
                    try
                    {
                        decimal fDegree = (Convert.ToDecimal(txt_C.Text) * 1.8M) + 32;
                        txt_F.Text = fDegree.ToString();
                        decimal kDegree = Convert.ToDecimal(txt_C.Text) + 273.15M;
                        txt_K.Text = kDegree.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("System Error : " + ex.Message, "Temperature Transducer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txt_C.Text = string.Empty;
                    txt_F.Text = string.Empty;
                    txt_K.Text = string.Empty;
                }
            }
            if (K)
            {
                if (!string.IsNullOrEmpty(txt_Degree.Text))
                {
                    txt_K.Text = txt_Degree.Text;
                    try
                    {
                        decimal cDegree = Convert.ToDecimal(txt_K.Text) - 273.15M;
                        txt_C.Text = cDegree.ToString();
                        decimal fDegree = (Convert.ToDecimal(txt_C.Text) * 1.8M) + 32;
                        txt_F.Text = fDegree.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("System Error : " + ex.Message, "Temperature Transducer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txt_C.Text = string.Empty;
                    txt_F.Text = string.Empty;
                    txt_K.Text = string.Empty;
                }
            }
        }

        private void lbl_Degree_Click(object sender, EventArgs e)
        {
            txt_Degree.Focus();
        }

        private void txt_Degree_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currentText = txt_Degree.Text;
            if (e.KeyChar == ',')
            {
                // Eğer metin boşsa veya ilk karakter virgülse, virgül yazılmasına izin verme
                if (string.IsNullOrEmpty(currentText) || currentText.Length == 0 || currentText[0] == ',')
                {
                    e.Handled = true; // Virgül yazılmasına izin verme
                }
            }
            if (e.KeyChar == (char)22) // Ctrl+V tuşu
            {
                string pastedText = Clipboard.GetText();
                if (!IsValidInput(pastedText))
                {
                    e.Handled = true;  // Yapıştırma işlemini engelle
                }
            }
            // Eğer girilen karakter rakam değilse, kontrol tuşu değilse ve virgül değilse
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Geçersiz karakteri iptal et
                return;
            }

            // Eğer virgül giriliyorsa ve zaten virgül varsa
            if (e.KeyChar == ',' && currentText.Contains(","))
            {
                e.Handled = true; // İkinci virgülü engelle
                return;
            }

            // Eğer virgül yoksa ve tam sayı kısmı 2 basamaktan fazla oluyorsa
            if (!currentText.Contains(",") && currentText.Length >= 2 && !char.IsControl(e.KeyChar))
            {
                e.Handled = false; // Virgül yoksa 2 basamaktan fazla girile bilir
                return;
            }
        }
        private bool IsValidInput(string input)
        {
            // Sadece rakamlar ve bir virgül olup olmadığını kontrol et
            if (string.IsNullOrEmpty(input)) return true;  // Boş metin kabul edilebilir

            string[] parts = input.Split(',');

            // Virgül bir tane olmalı ve her iki tarafta sayılar olmalı
            if (parts.Length > 2) return false;  // Birden fazla virgül kabul edilmez

            foreach (string part in parts)
            {
                if (!string.IsNullOrEmpty(part))
                {
                    // Part, sadece rakamlardan oluşmalı
                    foreach (char c in part)
                    {
                        if (!char.IsDigit(c))
                        {
                            return false;  // Eğer sayı değilse geçersiz
                        }
                    }
                }
            }

            // Virgül olmadan girilen değer geçerli olmalı
            return true;
        }

        private void btn_F_Click(object sender, EventArgs e)
        {
            F = true;
            K = false;
            C = false;
            btn_F.BackColor = Color.Turquoise;
            btn_F.ForeColor = Color.Black;
            btn_K.BackColor = Color.Transparent;
            btn_K.ForeColor = Color.Black;
            btn_C.BackColor = Color.Transparent;
            btn_C.ForeColor = Color.Black;
            if (!string.IsNullOrEmpty(txt_Degree.Text))
            {
                txt_F.Text = txt_Degree.Text;
                try
                {
                    decimal cDegree = (Convert.ToDecimal(txt_Degree.Text) - 32) / 1.8M;
                    txt_C.Text = cDegree.ToString();
                    decimal kDegree = cDegree + 273.15M;
                    txt_K.Text = kDegree.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("System Error : " + ex.Message, "Temperature Transducer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txt_C.Text = string.Empty;
                txt_F.Text = string.Empty;
                txt_K.Text = string.Empty;
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            F = false;
            K = false;
            C = true;
            btn_C.BackColor = Color.Turquoise;
            btn_C.ForeColor = Color.Black;
            btn_K.BackColor = Color.Transparent;
            btn_K.ForeColor = Color.Black;
            btn_F.BackColor = Color.Transparent;
            btn_F.ForeColor = Color.Black;
            if (!string.IsNullOrEmpty(txt_Degree.Text))
            {
                txt_C.Text = txt_Degree.Text;
                try
                {
                    decimal fDegree = (Convert.ToDecimal(txt_C.Text) * 1.8M) + 32;
                    txt_F.Text = fDegree.ToString();
                    decimal kDegree = Convert.ToDecimal(txt_C.Text) + 273.15M;
                    txt_K.Text = kDegree.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("System Error : " + ex.Message, "Temperature Transducer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txt_C.Text = string.Empty;
                txt_F.Text = string.Empty;
                txt_K.Text = string.Empty;
            }
        }

        private void btn_K_Click(object sender, EventArgs e)
        {
            F = false;
            K = true;
            C = false;
            btn_K.BackColor = Color.Turquoise;
            btn_K.ForeColor = Color.Black;
            btn_C.BackColor = Color.Transparent;
            btn_C.ForeColor = Color.Black;
            btn_F.BackColor = Color.Transparent;
            btn_F.ForeColor = Color.Black;
            if (!string.IsNullOrEmpty(txt_K.Text))
            {
                txt_K.Text = txt_Degree.Text;
                try
                {
                    decimal cDegree = Convert.ToDecimal(txt_K.Text) - 273.15M;
                    txt_C.Text = cDegree.ToString();
                    decimal fDegree = (Convert.ToDecimal(txt_C.Text) * 1.8M) + 32;
                    txt_F.Text = fDegree.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("System Error : " + ex.Message, "Temperature Transducer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txt_C.Text = string.Empty;
                txt_F.Text = string.Empty;
                txt_K.Text = string.Empty;
            }
        }

        private void btn_information_Click(object sender, EventArgs e)
        {
            Information_Popup popup = new Information_Popup();
            popup.ShowDialog();
        }
        private void copy_F_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_K.Text))
                Clipboard.SetText(txt_F.Text);
        }

        private void copy_C_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_C.Text))
                Clipboard.SetText(txt_C.Text);
        }

        private void copy_K_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_C.Text))
                Clipboard.SetText(txt_K.Text);
        }

        private void copy_All_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_C.Text) && !string.IsNullOrEmpty(txt_C.Text) && !string.IsNullOrEmpty(txt_K.Text))
                Clipboard.SetText("Honey Degrees, °F : " + txt_F.Text + " ; °C : " + txt_C.Text + " ; K : " + txt_K.Text);
        }

        private void x_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int cornerRadius = 10;

            Rectangle rect = new Rectangle(0, 0, btn_F.Width, btn_F.Height);

            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);

            path.AddArc(rect.Right - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);

            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);

            path.AddArc(rect.X, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);

            path.CloseFigure();

            btn_F.Region = new Region(path);
        }

        private void btn_C_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int cornerRadius = 10;

            Rectangle rect = new Rectangle(0, 0, btn_C.Width, btn_C.Height);

            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);

            path.AddArc(rect.Right - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);

            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);

            path.AddArc(rect.X, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);

            path.CloseFigure();

            btn_C.Region = new Region(path);
        }

        private void btn_K_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int cornerRadius = 10;

            Rectangle rect = new Rectangle(0, 0, btn_K.Width, btn_K.Height);

            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);

            path.AddArc(rect.Right - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);

            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);

            path.AddArc(rect.X, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);

            path.CloseFigure();

            btn_K.Region = new Region(path);
        }
    }
}
