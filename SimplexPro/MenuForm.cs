using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Подключил библиотеку Сервисов выполнения взаймодействия
using FontAwesome.Sharp;              // Библиотека для импортирования иконок
using System.Net.Sockets;

namespace SimplexPro
{
    public partial class MenuForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        
        public MenuForm()
        {
            InitializeComponent();
            customizeDesing();
            
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.None;

            Color BorderColor = Color.FromArgb(11, 7, 17);

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            BackMenuPanel.Controls.Add(leftBorderBtn);
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 0, 43);
            public static Color color2 = Color.FromArgb(255, 0, 43);
            public static Color color3 = Color.FromArgb(255, 0, 43);

        }
        private void ActivateButton(Object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null) //ссылка ну пустой объект 
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(11, 7, 17);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconPictureBox.IconChar = currentBtn.IconChar;
                iconPictureBox.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(11, 7, 17);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void customizeDesing() // Пустой метод
        {
            // Я скрываю панель подменю на которых находятся кнопки 
            TablePanel.Visible = false;
            ReportPanel.Visible = false;
            SpecPanel.Visible = false;
        }
        private void hideSubMenu() // Пустой метод
        {
            // В этом методе я скрываю панель подменю используя условие условие
            if (TablePanel.Visible = true)
                TablePanel.Visible = false;
            if (ReportPanel.Visible = true)
                ReportPanel.Visible = false;
            if (SpecPanel.Visible = true)
                SpecPanel.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }
        private Form activeForm = null;
        private void openMiniForm(Form miniForm) //Метод для открытия формы в форме
        {
            if (activeForm != null)
                activeForm?.Close();
            activeForm = miniForm;
            miniForm.TopLevel = false;
            miniForm.FormBorderStyle = FormBorderStyle.None;
            miniForm.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(miniForm);
            CenterPanel.Tag = miniForm;
            miniForm.BringToFront(); // вывожу на передний план, чтобы мой лаготип не мешал)
            miniForm.Show();

        }

        #region TableButton

        private void TableButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubMenu(TablePanel);
            ActivateButton(sender, RGBColors.color1);
            LabelMenu.Text = "Таблицы";
        }

        private void TableOwnerButton_Click(object sender, EventArgs e)
        {
           
            LabelMenu.Text = "Таблица владельцы";
            leftBorderBtn.Visible = false;
            openMiniForm(new FormOwner());
        }

        private void TableEstateButton_Click(object sender, EventArgs e)
        {
            LabelMenu.Text = "Таблица участки";
            leftBorderBtn.Visible = false;
            TableButton.BackColor = Color.FromArgb(11, 7, 17);
            openMiniForm(new FormSector());
        }
       
        private void TableSaleButton_Click(object sender, EventArgs e)
        {
            LabelMenu.Text = "Таблица дома";
            leftBorderBtn.Visible = false;
            openMiniForm(new FormHome());
        }

        private void TableRealtorsButton_Click(object sender, EventArgs e)
        {
            LabelMenu.Text = "Таблица квартиры";
            leftBorderBtn.Visible = false;
            openMiniForm(new FormApartment());
        }
        #endregion
        #region ReportButton
        private void ReportButton_Click(object sender, EventArgs e)
        {
            showSubMenu(ReportPanel);
            ActivateButton(sender, RGBColors.color2);
            LabelMenu.Text = "Отчёты";
        }

        private void ReportEstateButton_Click(object sender, EventArgs e)
        {
            LabelMenu.Text = "Отчёт владельцы";
            leftBorderBtn.Visible = false;
            openMiniForm(new FormOwner2());
        }

        private void ReportAgentButton_Click(object sender, EventArgs e)
        {
            LabelMenu.Text = "Отчёт участки";
            leftBorderBtn.Visible = false;
            openMiniForm(new FormSector2());
        }

        private void ReportOrderButton_Click(object sender, EventArgs e)
        {
            LabelMenu.Text = "Отчёт дома";
            leftBorderBtn.Visible = false;
            openMiniForm(new FormHome2());
        }

        private void ReportClientButton_Click(object sender, EventArgs e)
        {
            LabelMenu.Text = "Отчёт квартиры";
            leftBorderBtn.Visible = false;
            openMiniForm(new FormApartment2());
        }

        #endregion
        #region SpecButton
        private void SpecButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubMenu(SpecPanel);
            ActivateButton(sender, RGBColors.color3);
            LabelMenu.Text = "Спец. возможности";

        }

    

        private void SpecUserButton_Click(object sender, EventArgs e)
        {
            LabelMenu.Text = "Пользователи";
            leftBorderBtn.Visible = false;
            openMiniForm(new AddUser());
        }

        private void SpecToolButton_Click(object sender, EventArgs e)
        {
            
            leftBorderBtn.Visible = false;
            Form FormCalculator = new FormCalculator();
            FormCalculator.Show();
        }
        #endregion
        #region MouseEnter and MouseLeave
        private void TableButton_MouseEnter(object sender, EventArgs e)
        {
            TableButton.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void TableButton_MouseLeave(object sender, EventArgs e)
        {
            TableButton.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void ReportButton_MouseEnter(object sender, EventArgs e)
        {
            ReportButton.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void ReportButton_MouseLeave(object sender, EventArgs e)
        {
            ReportButton.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void SpecButton_MouseEnter(object sender, EventArgs e)
        {
            SpecButton.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void SpecButton_MouseLeave(object sender, EventArgs e)
        {
            SpecButton.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void TableOwnerButton_MouseEnter(object sender, EventArgs e)
        {
            TableOwnerButton.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void TableOwnerButton_MouseLeave(object sender, EventArgs e)
        {
            TableOwnerButton.BackColor = Color.FromArgb(35, 32, 39);
        }
        private void TableSaleButton_MouseEnter(object sender, EventArgs e)
        {
            TableSaleButton.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void TableSaleButton_MouseLeave(object sender, EventArgs e)
        {
            TableSaleButton.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void TableRealtorsButton_MouseEnter(object sender, EventArgs e)
        {
            TableRealtorsButton.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void TableRealtorsButton_MouseLeave(object sender, EventArgs e)
        {
            TableRealtorsButton.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void TableEstateButton_MouseEnter(object sender, EventArgs e)
        {
            TableEstateButton.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void TableEstateButton_MouseLeave(object sender, EventArgs e)
        {
            TableEstateButton.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void ReportEstateButton_MouseEnter(object sender, EventArgs e)
        {
            ReportEstateButton.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void ReportEstateButton_MouseLeave(object sender, EventArgs e)
        {
            ReportEstateButton.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void ReportAgentButton_MouseEnter(object sender, EventArgs e)
        {
            ReportAgentButton.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void ReportAgentButton_MouseLeave(object sender, EventArgs e)
        {
            ReportAgentButton.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void ReportOrderButton_MouseEnter(object sender, EventArgs e)
        {
            ReportOrderButton.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void ReportOrderButton_MouseLeave(object sender, EventArgs e)
        {
            ReportOrderButton.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void ReportClientButton_MouseEnter(object sender, EventArgs e)
        {
            ReportClientButton.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void ReportClientButton_MouseLeave(object sender, EventArgs e)
        {
            ReportClientButton.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void SpecUserButton_MouseEnter(object sender, EventArgs e)
        {
            SpecUserButton.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void SpecUserButton_MouseLeave(object sender, EventArgs e)
        {
            SpecUserButton.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void SpecToolButton_MouseEnter(object sender, EventArgs e)
        {
            SpecToolButton.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void SpecToolButton_MouseLeave(object sender, EventArgs e)
        {
            SpecToolButton.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(11, 7, 17);
        }
        #endregion

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Reset();
            hideSubMenu();

        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            iconPictureBox.IconChar = IconChar.Compass;
            iconPictureBox.IconColor = Color.FromArgb(255, 0, 43);
            LabelMenu.Text = "Меню";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessange(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ClosedPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessange(this.Handle, 0x112, 0xf012, 0);
        }

        private void picLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessange(this.Handle, 0x112, 0xf012, 0);
        }
        #region IconColor
        private void BackMenuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessange(this.Handle, 0x112, 0xf012, 0);
        }

        private void exitPic_MouseEnter(object sender, EventArgs e)
        {
            exitPic.IconColor = Color.FromArgb(255, 0, 43);
        }

        private void exitPic_MouseLeave(object sender, EventArgs e)
        {
            exitPic.IconColor = Color.White;
        }

        private void hide_expandPic_MouseEnter(object sender, EventArgs e)
        {
            hide_expandPic.IconColor = Color.FromArgb(255, 0, 43);
        }

        private void hide_expandPic_MouseLeave(object sender, EventArgs e)
        {
            hide_expandPic.IconColor = Color.White;
        }

        private void hidePic_MouseEnter(object sender, EventArgs e)
        {
            hidePic.IconColor = Color.FromArgb(255, 0, 43);
        }

        private void hidePic_MouseLeave(object sender, EventArgs e)
        {
            hidePic.IconColor = Color.White;
        }
        #endregion

        private void exitPic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hidePic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void hide_expandPic_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            
            Form FormLogin = new FormLogin();
            FormLogin.Show();
            this.Close();
        }

        private void LabelMenu_Click(object sender, EventArgs e)
        {

        }

        private void blankButton_Click(object sender, EventArgs e)
        {
            leftBorderBtn.Visible = false;
            Form FormBlanc = new FormBlanc();
            FormBlanc.Show();
        }

        private void blankButton_MouseEnter(object sender, EventArgs e)
        {
            blankButton.BackColor = Color.FromArgb(32, 30, 45);
        }

        private void blankButton_MouseLeave(object sender, EventArgs e)
        {
            blankButton.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
