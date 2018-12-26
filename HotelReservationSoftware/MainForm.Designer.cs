namespace HotelReservationSoftware
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.rtIndex = new System.Windows.Forms.RibbonTab();
            this.rpReservation = new System.Windows.Forms.RibbonPanel();
            this.rbRoomSearch = new System.Windows.Forms.RibbonButton();
            this.rbReservations = new System.Windows.Forms.RibbonButton();
            this.rbSearchGuest = new System.Windows.Forms.RibbonButton();
            this.rpHotelManagement = new System.Windows.Forms.RibbonPanel();
            this.rbCheckin = new System.Windows.Forms.RibbonButton();
            this.rbCheckout = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.rbRooms = new System.Windows.Forms.RibbonButton();
            this.rbRoomTypes = new System.Windows.Forms.RibbonButton();
            this.rbServices = new System.Windows.Forms.RibbonButton();
            this.rpAdministration = new System.Windows.Forms.RibbonPanel();
            this.rbUsers = new System.Windows.Forms.RibbonButton();
            this.rbChangePassword = new System.Windows.Forms.RibbonButton();
            this.rpExit = new System.Windows.Forms.RibbonPanel();
            this.rbLogout = new System.Windows.Forms.RibbonButton();
            this.rtReports = new System.Windows.Forms.RibbonTab();
            this.rpReports = new System.Windows.Forms.RibbonPanel();
            this.rbDailyOccupancy = new System.Windows.Forms.RibbonButton();
            this.rbReservationReport = new System.Windows.Forms.RibbonButton();
            this.rbRoomsReport = new System.Windows.Forms.RibbonButton();
            this.rbServiceReport = new System.Windows.Forms.RibbonButton();
            this.rbGuestsReport = new System.Windows.Forms.RibbonButton();
            this.rbCountryReport = new System.Windows.Forms.RibbonButton();
            this.rbMonths = new System.Windows.Forms.RibbonButton();
            this.rbCheckInReport = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.rbCheckOutReport = new System.Windows.Forms.RibbonButton();
            this.rtSupport = new System.Windows.Forms.RibbonTab();
            this.rpWorkWithDatabase = new System.Windows.Forms.RibbonPanel();
            this.rbBackup = new System.Windows.Forms.RibbonButton();
            this.rbRestore = new System.Windows.Forms.RibbonButton();
            this.rbHelp = new System.Windows.Forms.RibbonTab();
            this.rpAbout = new System.Windows.Forms.RibbonPanel();
            this.rbAbout = new System.Windows.Forms.RibbonButton();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTopLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::HotelReservationSoftware.Properties.Resources.user_login;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(12, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::HotelReservationSoftware.Properties.Resources.clock;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(12, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.BackColor = System.Drawing.Color.Transparent;
            this.lblLoggedUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLoggedUser.Location = new System.Drawing.Point(55, 13);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(50, 19);
            this.lblLoggedUser.TabIndex = 23;
            this.lblLoggedUser.Text = "label1";
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateAndTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateAndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDateAndTime.Location = new System.Drawing.Point(55, 66);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(50, 19);
            this.lblDateAndTime.TabIndex = 22;
            this.lblDateAndTime.Text = "label2";
            // 
            // ribbon1
            // 
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ribbon1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.RecentItemsCaption = null;
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 119);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon1.OrbText = null;
            this.ribbon1.OrbVisible = false;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.AltKey = null;
            this.ribbon1.QuickAcessToolbar.CheckedGroup = null;
            this.ribbon1.QuickAcessToolbar.Image = null;
            this.ribbon1.QuickAcessToolbar.Tag = null;
            this.ribbon1.QuickAcessToolbar.Text = null;
            this.ribbon1.QuickAcessToolbar.ToolTip = null;
            this.ribbon1.QuickAcessToolbar.ToolTipTitle = null;
            this.ribbon1.QuickAcessToolbar.Value = null;
            this.ribbon1.Size = new System.Drawing.Size(1772, 181);
            this.ribbon1.TabIndex = 27;
            this.ribbon1.Tabs.Add(this.rtIndex);
            this.ribbon1.Tabs.Add(this.rtReports);
            this.ribbon1.Tabs.Add(this.rtSupport);
            this.ribbon1.Tabs.Add(this.rbHelp);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.ribbon1.TabSpacing = 9;
            this.ribbon1.Text = "ribbon1";
            // 
            // rtIndex
            // 
            this.rtIndex.Panels.Add(this.rpReservation);
            this.rtIndex.Panels.Add(this.rpHotelManagement);
            this.rtIndex.Panels.Add(this.rpAdministration);
            this.rtIndex.Panels.Add(this.rpExit);
            this.rtIndex.Tag = null;
            this.rtIndex.Text = "Начало";
            this.rtIndex.ToolTip = "Начало";
            this.rtIndex.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.rtIndex.ToolTipImage = null;
            this.rtIndex.ToolTipTitle = null;
            this.rtIndex.Value = null;
            // 
            // rpReservation
            // 
            this.rpReservation.Items.Add(this.rbRoomSearch);
            this.rpReservation.Items.Add(this.rbReservations);
            this.rpReservation.Items.Add(this.rbSearchGuest);
            this.rpReservation.Tag = null;
            this.rpReservation.Text = "Управление на резервациите";
            // 
            // rbRoomSearch
            // 
            this.rbRoomSearch.AltKey = null;
            this.rbRoomSearch.CheckedGroup = null;
            this.rbRoomSearch.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbRoomSearch.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbRoomSearch.Image = global::HotelReservationSoftware.Properties.Resources.room_search_64x64;
            this.rbRoomSearch.SmallImage = global::HotelReservationSoftware.Properties.Resources.room_search_32x32;
            this.rbRoomSearch.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbRoomSearch.Tag = null;
            this.rbRoomSearch.Text = "Търсене на стаи";
            this.rbRoomSearch.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbRoomSearch.ToolTip = "Търсене на стаи";
            this.rbRoomSearch.ToolTipTitle = null;
            this.rbRoomSearch.Value = null;
            this.rbRoomSearch.Click += new System.EventHandler(this.rbRoomSearch_Click);
            // 
            // rbReservations
            // 
            this.rbReservations.AltKey = null;
            this.rbReservations.CheckedGroup = null;
            this.rbReservations.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbReservations.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbReservations.Image = ((System.Drawing.Image)(resources.GetObject("rbReservations.Image")));
            this.rbReservations.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbReservations.SmallImage")));
            this.rbReservations.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbReservations.Tag = null;
            this.rbReservations.Text = "Резервации";
            this.rbReservations.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbReservations.ToolTip = "Резервации";
            this.rbReservations.ToolTipTitle = null;
            this.rbReservations.Value = null;
            this.rbReservations.Click += new System.EventHandler(this.rbReservations_Click);
            // 
            // rbSearchGuest
            // 
            this.rbSearchGuest.AltKey = null;
            this.rbSearchGuest.CheckedGroup = null;
            this.rbSearchGuest.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbSearchGuest.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbSearchGuest.Image = ((System.Drawing.Image)(resources.GetObject("rbSearchGuest.Image")));
            this.rbSearchGuest.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbSearchGuest.SmallImage")));
            this.rbSearchGuest.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbSearchGuest.Tag = null;
            this.rbSearchGuest.Text = "Търсене на гост";
            this.rbSearchGuest.ToolTip = null;
            this.rbSearchGuest.ToolTipTitle = null;
            this.rbSearchGuest.Value = null;
            this.rbSearchGuest.Click += new System.EventHandler(this.rbSearchGuest_Click);
            // 
            // rpHotelManagement
            // 
            this.rpHotelManagement.Items.Add(this.rbCheckin);
            this.rpHotelManagement.Items.Add(this.rbCheckout);
            this.rpHotelManagement.Items.Add(this.rbRooms);
            this.rpHotelManagement.Items.Add(this.rbRoomTypes);
            this.rpHotelManagement.Items.Add(this.rbServices);
            this.rpHotelManagement.Tag = null;
            this.rpHotelManagement.Text = "Управление на хотела";
            // 
            // rbCheckin
            // 
            this.rbCheckin.AltKey = null;
            this.rbCheckin.CheckedGroup = null;
            this.rbCheckin.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbCheckin.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbCheckin.Image = ((System.Drawing.Image)(resources.GetObject("rbCheckin.Image")));
            this.rbCheckin.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbCheckin.SmallImage")));
            this.rbCheckin.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbCheckin.Tag = null;
            this.rbCheckin.Text = "Пристигащи";
            this.rbCheckin.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbCheckin.ToolTip = "Пристигащи";
            this.rbCheckin.ToolTipTitle = null;
            this.rbCheckin.Value = null;
            this.rbCheckin.Click += new System.EventHandler(this.rbCheckin_Click);
            // 
            // rbCheckout
            // 
            this.rbCheckout.AltKey = null;
            this.rbCheckout.CheckedGroup = null;
            this.rbCheckout.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbCheckout.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbCheckout.DropDownItems.Add(this.ribbonButton1);
            this.rbCheckout.DropDownItems.Add(this.ribbonButton2);
            this.rbCheckout.DropDownItems.Add(this.ribbonButton3);
            this.rbCheckout.Image = ((System.Drawing.Image)(resources.GetObject("rbCheckout.Image")));
            this.rbCheckout.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbCheckout.SmallImage")));
            this.rbCheckout.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbCheckout.Tag = null;
            this.rbCheckout.Text = "Заминаващи";
            this.rbCheckout.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbCheckout.ToolTip = "Заминаващи";
            this.rbCheckout.ToolTipTitle = null;
            this.rbCheckout.Value = null;
            this.rbCheckout.Click += new System.EventHandler(this.rbCheckout_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.AltKey = null;
            this.ribbonButton1.CheckedGroup = null;
            this.ribbonButton1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton1.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton1.Tag = null;
            this.ribbonButton1.Text = "ribbonButton1";
            this.ribbonButton1.ToolTip = null;
            this.ribbonButton1.ToolTipTitle = null;
            this.ribbonButton1.Value = null;
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.AltKey = null;
            this.ribbonButton2.CheckedGroup = null;
            this.ribbonButton2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton2.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton2.Tag = null;
            this.ribbonButton2.Text = "ribbonButton2";
            this.ribbonButton2.ToolTip = null;
            this.ribbonButton2.ToolTipTitle = null;
            this.ribbonButton2.Value = null;
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.AltKey = null;
            this.ribbonButton3.CheckedGroup = null;
            this.ribbonButton3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton3.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton3.Tag = null;
            this.ribbonButton3.Text = "ribbonButton3";
            this.ribbonButton3.ToolTip = null;
            this.ribbonButton3.ToolTipTitle = null;
            this.ribbonButton3.Value = null;
            // 
            // rbRooms
            // 
            this.rbRooms.AltKey = null;
            this.rbRooms.CheckedGroup = null;
            this.rbRooms.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbRooms.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbRooms.Image = ((System.Drawing.Image)(resources.GetObject("rbRooms.Image")));
            this.rbRooms.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbRooms.SmallImage")));
            this.rbRooms.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbRooms.Tag = null;
            this.rbRooms.Text = "Стаи";
            this.rbRooms.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbRooms.ToolTip = "Стаи";
            this.rbRooms.ToolTipTitle = null;
            this.rbRooms.Value = null;
            this.rbRooms.Click += new System.EventHandler(this.rbRooms_Click);
            // 
            // rbRoomTypes
            // 
            this.rbRoomTypes.AltKey = null;
            this.rbRoomTypes.CheckedGroup = null;
            this.rbRoomTypes.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbRoomTypes.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbRoomTypes.Image = ((System.Drawing.Image)(resources.GetObject("rbRoomTypes.Image")));
            this.rbRoomTypes.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbRoomTypes.SmallImage")));
            this.rbRoomTypes.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbRoomTypes.Tag = null;
            this.rbRoomTypes.Text = "Типове стаи";
            this.rbRoomTypes.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbRoomTypes.ToolTip = "Типове стаи";
            this.rbRoomTypes.ToolTipTitle = null;
            this.rbRoomTypes.Value = null;
            this.rbRoomTypes.Click += new System.EventHandler(this.rbRoomTypes_Click);
            // 
            // rbServices
            // 
            this.rbServices.AltKey = null;
            this.rbServices.CheckedGroup = null;
            this.rbServices.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbServices.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbServices.Image = ((System.Drawing.Image)(resources.GetObject("rbServices.Image")));
            this.rbServices.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbServices.SmallImage")));
            this.rbServices.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbServices.Tag = null;
            this.rbServices.Text = "Услуги";
            this.rbServices.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbServices.ToolTip = "Услуги";
            this.rbServices.ToolTipTitle = null;
            this.rbServices.Value = null;
            this.rbServices.Click += new System.EventHandler(this.rbServices_Click);
            // 
            // rpAdministration
            // 
            this.rpAdministration.Items.Add(this.rbUsers);
            this.rpAdministration.Items.Add(this.rbChangePassword);
            this.rpAdministration.Tag = null;
            this.rpAdministration.Text = "Администрация";
            // 
            // rbUsers
            // 
            this.rbUsers.AltKey = null;
            this.rbUsers.CheckedGroup = null;
            this.rbUsers.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbUsers.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbUsers.Image = global::HotelReservationSoftware.Properties.Resources.user_group_64x641;
            this.rbUsers.SmallImage = global::HotelReservationSoftware.Properties.Resources.user_group_32x321;
            this.rbUsers.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbUsers.Tag = null;
            this.rbUsers.Text = "Потребители";
            this.rbUsers.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbUsers.ToolTip = "Потребители";
            this.rbUsers.ToolTipTitle = null;
            this.rbUsers.Value = null;
            this.rbUsers.Click += new System.EventHandler(this.rbUsers_Click);
            // 
            // rbChangePassword
            // 
            this.rbChangePassword.AltKey = null;
            this.rbChangePassword.CheckedGroup = null;
            this.rbChangePassword.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbChangePassword.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbChangePassword.Image = global::HotelReservationSoftware.Properties.Resources.pass_120;
            this.rbChangePassword.SmallImage = global::HotelReservationSoftware.Properties.Resources.pass_32x17;
            this.rbChangePassword.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbChangePassword.Tag = null;
            this.rbChangePassword.Text = "Смени парола";
            this.rbChangePassword.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbChangePassword.ToolTip = "Смени парола";
            this.rbChangePassword.ToolTipTitle = null;
            this.rbChangePassword.Value = null;
            this.rbChangePassword.Click += new System.EventHandler(this.rbChangePassword_Click);
            // 
            // rpExit
            // 
            this.rpExit.Items.Add(this.rbLogout);
            this.rpExit.Tag = null;
            this.rpExit.Text = "Изход";
            // 
            // rbLogout
            // 
            this.rbLogout.AltKey = null;
            this.rbLogout.CheckedGroup = null;
            this.rbLogout.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbLogout.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbLogout.Image = global::HotelReservationSoftware.Properties.Resources.logout_64x64;
            this.rbLogout.SmallImage = global::HotelReservationSoftware.Properties.Resources.logout_32x32;
            this.rbLogout.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbLogout.Tag = null;
            this.rbLogout.Text = "Излез от профила";
            this.rbLogout.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbLogout.ToolTip = "Излез";
            this.rbLogout.ToolTipTitle = null;
            this.rbLogout.Value = null;
            this.rbLogout.Click += new System.EventHandler(this.rbLogout_Click);
            // 
            // rtReports
            // 
            this.rtReports.Panels.Add(this.rpReports);
            this.rtReports.Tag = null;
            this.rtReports.Text = "Отчети";
            this.rtReports.ToolTip = null;
            this.rtReports.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.rtReports.ToolTipImage = null;
            this.rtReports.ToolTipTitle = null;
            this.rtReports.Value = null;
            // 
            // rpReports
            // 
            this.rpReports.Items.Add(this.rbDailyOccupancy);
            this.rpReports.Items.Add(this.rbReservationReport);
            this.rpReports.Items.Add(this.rbRoomsReport);
            this.rpReports.Items.Add(this.rbServiceReport);
            this.rpReports.Items.Add(this.rbGuestsReport);
            this.rpReports.Items.Add(this.rbCountryReport);
            this.rpReports.Items.Add(this.rbMonths);
            this.rpReports.Items.Add(this.rbCheckInReport);
            this.rpReports.Items.Add(this.rbCheckOutReport);
            this.rpReports.Tag = null;
            this.rpReports.Text = "Отчети и статистики";
            // 
            // rbDailyOccupancy
            // 
            this.rbDailyOccupancy.AltKey = null;
            this.rbDailyOccupancy.CheckedGroup = null;
            this.rbDailyOccupancy.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbDailyOccupancy.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbDailyOccupancy.Image = ((System.Drawing.Image)(resources.GetObject("rbDailyOccupancy.Image")));
            this.rbDailyOccupancy.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbDailyOccupancy.SmallImage")));
            this.rbDailyOccupancy.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbDailyOccupancy.Tag = null;
            this.rbDailyOccupancy.Text = "Дневна заетост";
            this.rbDailyOccupancy.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbDailyOccupancy.ToolTip = "Дневна заетост";
            this.rbDailyOccupancy.ToolTipTitle = null;
            this.rbDailyOccupancy.Value = null;
            this.rbDailyOccupancy.Click += new System.EventHandler(this.rbDailyOccupancy_Click);
            // 
            // rbReservationReport
            // 
            this.rbReservationReport.AltKey = null;
            this.rbReservationReport.CheckedGroup = null;
            this.rbReservationReport.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbReservationReport.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbReservationReport.Image = ((System.Drawing.Image)(resources.GetObject("rbReservationReport.Image")));
            this.rbReservationReport.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbReservationReport.SmallImage")));
            this.rbReservationReport.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbReservationReport.Tag = null;
            this.rbReservationReport.Text = "Резервации";
            this.rbReservationReport.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbReservationReport.ToolTip = "Резервации";
            this.rbReservationReport.ToolTipTitle = null;
            this.rbReservationReport.Value = null;
            this.rbReservationReport.Click += new System.EventHandler(this.rbReservationReport_Click);
            // 
            // rbRoomsReport
            // 
            this.rbRoomsReport.AltKey = null;
            this.rbRoomsReport.CheckedGroup = null;
            this.rbRoomsReport.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbRoomsReport.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbRoomsReport.Image = ((System.Drawing.Image)(resources.GetObject("rbRoomsReport.Image")));
            this.rbRoomsReport.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbRoomsReport.SmallImage")));
            this.rbRoomsReport.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbRoomsReport.Tag = null;
            this.rbRoomsReport.Text = "Стаи";
            this.rbRoomsReport.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbRoomsReport.ToolTip = "Стаи";
            this.rbRoomsReport.ToolTipTitle = null;
            this.rbRoomsReport.Value = null;
            this.rbRoomsReport.Click += new System.EventHandler(this.rbRoomsReport_Click);
            // 
            // rbServiceReport
            // 
            this.rbServiceReport.AltKey = null;
            this.rbServiceReport.CheckedGroup = null;
            this.rbServiceReport.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbServiceReport.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbServiceReport.Image = ((System.Drawing.Image)(resources.GetObject("rbServiceReport.Image")));
            this.rbServiceReport.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbServiceReport.SmallImage")));
            this.rbServiceReport.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbServiceReport.Tag = null;
            this.rbServiceReport.Text = "Услуги";
            this.rbServiceReport.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbServiceReport.ToolTip = "Услуги";
            this.rbServiceReport.ToolTipTitle = null;
            this.rbServiceReport.Value = null;
            this.rbServiceReport.Click += new System.EventHandler(this.rbServiceReport_Click);
            // 
            // rbGuestsReport
            // 
            this.rbGuestsReport.AltKey = null;
            this.rbGuestsReport.CheckedGroup = null;
            this.rbGuestsReport.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbGuestsReport.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbGuestsReport.Image = ((System.Drawing.Image)(resources.GetObject("rbGuestsReport.Image")));
            this.rbGuestsReport.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbGuestsReport.SmallImage")));
            this.rbGuestsReport.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbGuestsReport.Tag = null;
            this.rbGuestsReport.Text = "Гости";
            this.rbGuestsReport.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbGuestsReport.ToolTip = "Гости";
            this.rbGuestsReport.ToolTipTitle = null;
            this.rbGuestsReport.Value = null;
            this.rbGuestsReport.Click += new System.EventHandler(this.rbGuestsReport_Click);
            // 
            // rbCountryReport
            // 
            this.rbCountryReport.AltKey = null;
            this.rbCountryReport.CheckedGroup = null;
            this.rbCountryReport.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbCountryReport.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbCountryReport.Image = ((System.Drawing.Image)(resources.GetObject("rbCountryReport.Image")));
            this.rbCountryReport.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbCountryReport.SmallImage")));
            this.rbCountryReport.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbCountryReport.Tag = null;
            this.rbCountryReport.Text = "Държава - гости";
            this.rbCountryReport.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbCountryReport.ToolTip = "Държави";
            this.rbCountryReport.ToolTipTitle = null;
            this.rbCountryReport.Value = null;
            this.rbCountryReport.Click += new System.EventHandler(this.rbCountryReport_Click);
            // 
            // rbMonths
            // 
            this.rbMonths.AltKey = null;
            this.rbMonths.CheckedGroup = null;
            this.rbMonths.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbMonths.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbMonths.Image = ((System.Drawing.Image)(resources.GetObject("rbMonths.Image")));
            this.rbMonths.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbMonths.SmallImage")));
            this.rbMonths.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbMonths.Tag = null;
            this.rbMonths.Text = "Месец - гости ..";
            this.rbMonths.ToolTip = null;
            this.rbMonths.ToolTipTitle = null;
            this.rbMonths.Value = null;
            this.rbMonths.Click += new System.EventHandler(this.rbMonths_Click);
            // 
            // rbCheckInReport
            // 
            this.rbCheckInReport.AltKey = null;
            this.rbCheckInReport.CheckedGroup = null;
            this.rbCheckInReport.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbCheckInReport.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbCheckInReport.DropDownItems.Add(this.ribbonButton4);
            this.rbCheckInReport.Image = ((System.Drawing.Image)(resources.GetObject("rbCheckInReport.Image")));
            this.rbCheckInReport.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbCheckInReport.SmallImage")));
            this.rbCheckInReport.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbCheckInReport.Tag = null;
            this.rbCheckInReport.Text = "Пристигащи";
            this.rbCheckInReport.ToolTip = null;
            this.rbCheckInReport.ToolTipTitle = null;
            this.rbCheckInReport.Value = null;
            this.rbCheckInReport.Click += new System.EventHandler(this.rbCheckInReport_Click);
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.AltKey = null;
            this.ribbonButton4.CheckedGroup = null;
            this.ribbonButton4.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton4.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton4.Tag = null;
            this.ribbonButton4.Text = "ribbonButton4";
            this.ribbonButton4.ToolTip = null;
            this.ribbonButton4.ToolTipTitle = null;
            this.ribbonButton4.Value = null;
            // 
            // rbCheckOutReport
            // 
            this.rbCheckOutReport.AltKey = null;
            this.rbCheckOutReport.CheckedGroup = null;
            this.rbCheckOutReport.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbCheckOutReport.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbCheckOutReport.Image = ((System.Drawing.Image)(resources.GetObject("rbCheckOutReport.Image")));
            this.rbCheckOutReport.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbCheckOutReport.SmallImage")));
            this.rbCheckOutReport.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbCheckOutReport.Tag = null;
            this.rbCheckOutReport.Text = "Заминаващи";
            this.rbCheckOutReport.ToolTip = null;
            this.rbCheckOutReport.ToolTipTitle = null;
            this.rbCheckOutReport.Value = null;
            this.rbCheckOutReport.Click += new System.EventHandler(this.rbCheckOutReport_Click);
            // 
            // rtSupport
            // 
            this.rtSupport.Panels.Add(this.rpWorkWithDatabase);
            this.rtSupport.Tag = null;
            this.rtSupport.Text = "Поддръжка";
            this.rtSupport.ToolTip = null;
            this.rtSupport.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.rtSupport.ToolTipImage = null;
            this.rtSupport.ToolTipTitle = null;
            this.rtSupport.Value = null;
            // 
            // rpWorkWithDatabase
            // 
            this.rpWorkWithDatabase.Items.Add(this.rbBackup);
            this.rpWorkWithDatabase.Items.Add(this.rbRestore);
            this.rpWorkWithDatabase.Tag = null;
            this.rpWorkWithDatabase.Text = "Работа с базата";
            // 
            // rbBackup
            // 
            this.rbBackup.AltKey = null;
            this.rbBackup.CheckedGroup = null;
            this.rbBackup.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBackup.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBackup.Image = ((System.Drawing.Image)(resources.GetObject("rbBackup.Image")));
            this.rbBackup.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBackup.SmallImage")));
            this.rbBackup.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBackup.Tag = null;
            this.rbBackup.Text = "Backup";
            this.rbBackup.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbBackup.ToolTip = "Backup";
            this.rbBackup.ToolTipTitle = null;
            this.rbBackup.Value = null;
            this.rbBackup.Click += new System.EventHandler(this.rbBackup_Click);
            // 
            // rbRestore
            // 
            this.rbRestore.AltKey = null;
            this.rbRestore.CheckedGroup = null;
            this.rbRestore.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbRestore.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbRestore.Image = ((System.Drawing.Image)(resources.GetObject("rbRestore.Image")));
            this.rbRestore.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbRestore.SmallImage")));
            this.rbRestore.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbRestore.Tag = null;
            this.rbRestore.Text = "Restore";
            this.rbRestore.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbRestore.ToolTip = "Restore";
            this.rbRestore.ToolTipTitle = null;
            this.rbRestore.Value = null;
            this.rbRestore.Click += new System.EventHandler(this.rbRestore_Click);
            // 
            // rbHelp
            // 
            this.rbHelp.Panels.Add(this.rpAbout);
            this.rbHelp.Tag = null;
            this.rbHelp.Text = "Помощ";
            this.rbHelp.ToolTip = null;
            this.rbHelp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.rbHelp.ToolTipImage = null;
            this.rbHelp.ToolTipTitle = null;
            this.rbHelp.Value = null;
            // 
            // rpAbout
            // 
            this.rpAbout.Items.Add(this.rbAbout);
            this.rpAbout.Tag = null;
            this.rpAbout.Text = "Помощ";
            // 
            // rbAbout
            // 
            this.rbAbout.AltKey = null;
            this.rbAbout.CheckedGroup = null;
            this.rbAbout.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbAbout.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbAbout.Image = ((System.Drawing.Image)(resources.GetObject("rbAbout.Image")));
            this.rbAbout.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbAbout.SmallImage")));
            this.rbAbout.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbAbout.Tag = null;
            this.rbAbout.Text = "Относно";
            this.rbAbout.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbAbout.ToolTip = "Относно";
            this.rbAbout.ToolTipTitle = null;
            this.rbAbout.Value = null;
            this.rbAbout.Click += new System.EventHandler(this.rbAbout_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelLeft.Location = new System.Drawing.Point(0, 274);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(255, 794);
            this.panelLeft.TabIndex = 28;
            // 
            // panelMainContent
            // 
            this.panelMainContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainContent.AutoSize = true;
            this.panelMainContent.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelMainContent.Location = new System.Drawing.Point(257, 179);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(1511, 637);
            this.panelMainContent.TabIndex = 29;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.AutoSize = true;
            this.panelTopLeft.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelTopLeft.Controls.Add(this.pictureBox3);
            this.panelTopLeft.Controls.Add(this.lblDateAndTime);
            this.panelTopLeft.Controls.Add(this.pictureBox2);
            this.panelTopLeft.Controls.Add(this.lblLoggedUser);
            this.panelTopLeft.Location = new System.Drawing.Point(0, 180);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(255, 96);
            this.panelTopLeft.TabIndex = 30;
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1772, 761);
            this.Controls.Add(this.panelTopLeft);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.ribbon1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Хотел";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTopLeft.ResumeLayout(false);
            this.panelTopLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab rtIndex;
        private System.Windows.Forms.RibbonPanel rpReservation;
        private System.Windows.Forms.RibbonButton rbRoomSearch;
        private System.Windows.Forms.RibbonButton rbReservations;
        private System.Windows.Forms.RibbonPanel rpHotelManagement;
        private System.Windows.Forms.RibbonButton rbCheckin;
        private System.Windows.Forms.RibbonButton rbCheckout;
        private System.Windows.Forms.RibbonPanel rpAdministration;
        private System.Windows.Forms.RibbonButton rbUsers;
        private System.Windows.Forms.RibbonButton rbChangePassword;
        private System.Windows.Forms.RibbonPanel rpExit;
        private System.Windows.Forms.RibbonButton rbLogout;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton rbRooms;
        private System.Windows.Forms.RibbonButton rbRoomTypes;
        private System.Windows.Forms.RibbonButton rbServices;
        private System.Windows.Forms.RibbonTab rtReports;
        private System.Windows.Forms.RibbonTab rtSupport;
        private System.Windows.Forms.RibbonPanel rpWorkWithDatabase;
        private System.Windows.Forms.RibbonButton rbBackup;
        private System.Windows.Forms.RibbonButton rbRestore;
        private System.Windows.Forms.RibbonTab rbHelp;
        private System.Windows.Forms.RibbonPanel rpAbout;
        private System.Windows.Forms.RibbonButton rbAbout;
        private System.Windows.Forms.RibbonPanel rpReports;
        private System.Windows.Forms.RibbonButton rbDailyOccupancy;
        private System.Windows.Forms.RibbonButton rbReservationReport;
        private System.Windows.Forms.RibbonButton rbRoomsReport;
        private System.Windows.Forms.RibbonButton rbServiceReport;
        private System.Windows.Forms.RibbonButton rbGuestsReport;
        private System.Windows.Forms.RibbonButton rbCountryReport;
        private System.Windows.Forms.RibbonButton rbSearchGuest;
        private System.Windows.Forms.RibbonButton rbMonths;
        private System.Windows.Forms.RibbonButton rbCheckInReport;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonButton rbCheckOutReport;
    }
}