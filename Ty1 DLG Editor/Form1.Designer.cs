namespace Ty1_DLG_Editor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TabControl = new TabControl();
            ActorTab = new TabPage();
            ATSButtonActor = new Button();
            ActorList = new ListBox();
            AddActorButton = new Button();
            ActorModelLabel = new Label();
            ActorModel = new TextBox();
            ActorNameLabel = new Label();
            ActorName = new TextBox();
            CameraTab = new TabPage();
            ATSButtonCamera = new Button();
            ActiveCameraPanel = new Panel();
            ATSButtonCamSpline = new Button();
            ATSButtonTCB = new Button();
            AddCamSplineButton = new Button();
            TrgtXYZLabel = new Label();
            TrgtXYZ = new TextBox();
            SrcXYZLabel = new Label();
            SrcXYZ = new TextBox();
            AddTCBButton = new Button();
            TCBSplineW2Label = new Label();
            TCBSplineW2 = new TextBox();
            TCBSplineW1Label = new Label();
            TCBSplineW1 = new TextBox();
            CamSplineList = new ListBox();
            TCBInfoList = new ListBox();
            ForceLengthCheck = new CheckBox();
            ForceLengthLabel = new Label();
            CamTimeLabel = new Label();
            CamTime = new TextBox();
            FarPlaneLabel = new Label();
            FarPlane = new TextBox();
            CameraList = new ListBox();
            AddCameraButton = new Button();
            NearPlaneLabel = new Label();
            NearPlane = new TextBox();
            FOVLabel = new Label();
            FOV = new TextBox();
            PhonemeTab = new TabPage();
            ATSButtonPhoneme = new Button();
            SubtitleFileName = new TextBox();
            SubtitleFileNameLabel = new Label();
            OutTimeLabel = new Label();
            OutTime = new TextBox();
            InTimeLabel = new Label();
            InTime = new TextBox();
            SubtitleNrLabel = new Label();
            SubtitleNr = new TextBox();
            PhonemeNameLabel = new Label();
            PhonemeName = new TextBox();
            PhraseTab = new TabPage();
            ATSButtonPhrase = new Button();
            EffectDelayLabel = new Label();
            EffectDelay = new TextBox();
            EffectParam3 = new TextBox();
            EffectParam2 = new TextBox();
            AddPhraseButton = new Button();
            CameraCombo = new ComboBox();
            PhraseList = new ListBox();
            EffectParamsLabel = new Label();
            EffectParam1 = new TextBox();
            CameraLabel = new Label();
            CellTab = new TabPage();
            CellPanel = new Panel();
            ActorRot = new TextBox();
            ApplyCellButton = new Button();
            RotLabel = new Label();
            ActorPos = new TextBox();
            PosLabel = new Label();
            FitBodyAnimCheck = new CheckBox();
            BodyAnim = new TextBox();
            BodyAnimLabel = new Label();
            BodyType = new TextBox();
            BodyTypeLabel = new Label();
            FitHeadAnimCheck = new CheckBox();
            HeadAnim = new TextBox();
            HeadAnimLabel = new Label();
            HeadType = new TextBox();
            HeadTypeLabel = new Label();
            LipScaler = new TextBox();
            LipScalerLabel = new Label();
            LipAnimName = new TextBox();
            SpeakingCheck = new CheckBox();
            LipAnimLabel = new Label();
            PhraseCombo = new ComboBox();
            PhraseLabel = new Label();
            ActorCombo = new ComboBox();
            ActorLabel = new Label();
            OutputTab = new TabPage();
            OutputText = new RichTextBox();
            WarningMessage = new Label();
            PhonemePhraseCombo = new ComboBox();
            PhonemePhraseLabel = new Label();
            TabControl.SuspendLayout();
            ActorTab.SuspendLayout();
            CameraTab.SuspendLayout();
            ActiveCameraPanel.SuspendLayout();
            PhonemeTab.SuspendLayout();
            PhraseTab.SuspendLayout();
            CellTab.SuspendLayout();
            CellPanel.SuspendLayout();
            OutputTab.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(ActorTab);
            TabControl.Controls.Add(CameraTab);
            TabControl.Controls.Add(PhraseTab);
            TabControl.Controls.Add(PhonemeTab);
            TabControl.Controls.Add(CellTab);
            TabControl.Controls.Add(OutputTab);
            TabControl.Dock = DockStyle.Top;
            TabControl.ItemSize = new Size(50, 20);
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(518, 431);
            TabControl.TabIndex = 0;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // ActorTab
            // 
            ActorTab.Controls.Add(ATSButtonActor);
            ActorTab.Controls.Add(ActorList);
            ActorTab.Controls.Add(AddActorButton);
            ActorTab.Controls.Add(ActorModelLabel);
            ActorTab.Controls.Add(ActorModel);
            ActorTab.Controls.Add(ActorNameLabel);
            ActorTab.Controls.Add(ActorName);
            ActorTab.Location = new Point(4, 24);
            ActorTab.Name = "ActorTab";
            ActorTab.Padding = new Padding(3);
            ActorTab.Size = new Size(510, 403);
            ActorTab.TabIndex = 0;
            ActorTab.Text = "Actor";
            ActorTab.UseVisualStyleBackColor = true;
            // 
            // ATSButtonActor
            // 
            ATSButtonActor.Location = new Point(130, 97);
            ATSButtonActor.Name = "ATSButtonActor";
            ATSButtonActor.Size = new Size(117, 23);
            ATSButtonActor.TabIndex = 12;
            ATSButtonActor.Text = "Apply To Selected";
            ATSButtonActor.UseVisualStyleBackColor = true;
            ATSButtonActor.Click += ATSButtonActor_Click;
            // 
            // ActorList
            // 
            ActorList.FormattingEnabled = true;
            ActorList.ItemHeight = 15;
            ActorList.Location = new Point(253, 6);
            ActorList.Name = "ActorList";
            ActorList.Size = new Size(249, 379);
            ActorList.TabIndex = 11;
            ActorList.SelectedIndexChanged += ActorList_SelectedIndexChanged;
            ActorList.KeyDown += RemoveSelected;
            // 
            // AddActorButton
            // 
            AddActorButton.Location = new Point(8, 97);
            AddActorButton.Name = "AddActorButton";
            AddActorButton.Size = new Size(75, 23);
            AddActorButton.TabIndex = 10;
            AddActorButton.Text = "Add Actor";
            AddActorButton.UseVisualStyleBackColor = true;
            AddActorButton.Click += AddActorButton_Click;
            // 
            // ActorModelLabel
            // 
            ActorModelLabel.AutoSize = true;
            ActorModelLabel.Location = new Point(8, 50);
            ActorModelLabel.Name = "ActorModelLabel";
            ActorModelLabel.Size = new Size(73, 15);
            ActorModelLabel.TabIndex = 8;
            ActorModelLabel.Text = "Actor Model";
            // 
            // ActorModel
            // 
            ActorModel.Location = new Point(8, 68);
            ActorModel.Name = "ActorModel";
            ActorModel.Size = new Size(239, 23);
            ActorModel.TabIndex = 9;
            // 
            // ActorNameLabel
            // 
            ActorNameLabel.AutoSize = true;
            ActorNameLabel.Location = new Point(8, 6);
            ActorNameLabel.Name = "ActorNameLabel";
            ActorNameLabel.Size = new Size(71, 15);
            ActorNameLabel.TabIndex = 6;
            ActorNameLabel.Text = "Actor Name";
            // 
            // ActorName
            // 
            ActorName.Location = new Point(8, 24);
            ActorName.Name = "ActorName";
            ActorName.Size = new Size(239, 23);
            ActorName.TabIndex = 7;
            // 
            // CameraTab
            // 
            CameraTab.Controls.Add(ATSButtonCamera);
            CameraTab.Controls.Add(ActiveCameraPanel);
            CameraTab.Controls.Add(ForceLengthCheck);
            CameraTab.Controls.Add(ForceLengthLabel);
            CameraTab.Controls.Add(CamTimeLabel);
            CameraTab.Controls.Add(CamTime);
            CameraTab.Controls.Add(FarPlaneLabel);
            CameraTab.Controls.Add(FarPlane);
            CameraTab.Controls.Add(CameraList);
            CameraTab.Controls.Add(AddCameraButton);
            CameraTab.Controls.Add(NearPlaneLabel);
            CameraTab.Controls.Add(NearPlane);
            CameraTab.Controls.Add(FOVLabel);
            CameraTab.Controls.Add(FOV);
            CameraTab.Location = new Point(4, 24);
            CameraTab.Name = "CameraTab";
            CameraTab.Size = new Size(510, 403);
            CameraTab.TabIndex = 4;
            CameraTab.Text = "Camera";
            CameraTab.UseVisualStyleBackColor = true;
            // 
            // ATSButtonCamera
            // 
            ATSButtonCamera.Location = new Point(130, 142);
            ATSButtonCamera.Name = "ATSButtonCamera";
            ATSButtonCamera.Size = new Size(117, 23);
            ATSButtonCamera.TabIndex = 45;
            ATSButtonCamera.Text = "Apply To Selected";
            ATSButtonCamera.UseVisualStyleBackColor = true;
            ATSButtonCamera.Click += ATSButtonCamera_Click;
            // 
            // ActiveCameraPanel
            // 
            ActiveCameraPanel.Controls.Add(ATSButtonCamSpline);
            ActiveCameraPanel.Controls.Add(ATSButtonTCB);
            ActiveCameraPanel.Controls.Add(AddCamSplineButton);
            ActiveCameraPanel.Controls.Add(TrgtXYZLabel);
            ActiveCameraPanel.Controls.Add(TrgtXYZ);
            ActiveCameraPanel.Controls.Add(SrcXYZLabel);
            ActiveCameraPanel.Controls.Add(SrcXYZ);
            ActiveCameraPanel.Controls.Add(AddTCBButton);
            ActiveCameraPanel.Controls.Add(TCBSplineW2Label);
            ActiveCameraPanel.Controls.Add(TCBSplineW2);
            ActiveCameraPanel.Controls.Add(TCBSplineW1Label);
            ActiveCameraPanel.Controls.Add(TCBSplineW1);
            ActiveCameraPanel.Controls.Add(CamSplineList);
            ActiveCameraPanel.Controls.Add(TCBInfoList);
            ActiveCameraPanel.Dock = DockStyle.Bottom;
            ActiveCameraPanel.Enabled = false;
            ActiveCameraPanel.Location = new Point(0, 170);
            ActiveCameraPanel.Name = "ActiveCameraPanel";
            ActiveCameraPanel.Size = new Size(510, 233);
            ActiveCameraPanel.TabIndex = 44;
            // 
            // ATSButtonCamSpline
            // 
            ATSButtonCamSpline.Location = new Point(130, 200);
            ATSButtonCamSpline.Name = "ATSButtonCamSpline";
            ATSButtonCamSpline.Size = new Size(117, 23);
            ATSButtonCamSpline.TabIndex = 64;
            ATSButtonCamSpline.Text = "Apply To Selected";
            ATSButtonCamSpline.UseVisualStyleBackColor = true;
            ATSButtonCamSpline.Click += ATSButtonCamSpline_Click;
            // 
            // ATSButtonTCB
            // 
            ATSButtonTCB.Location = new Point(130, 57);
            ATSButtonTCB.Name = "ATSButtonTCB";
            ATSButtonTCB.Size = new Size(117, 23);
            ATSButtonTCB.TabIndex = 46;
            ATSButtonTCB.Text = "Apply To Selected";
            ATSButtonTCB.UseVisualStyleBackColor = true;
            ATSButtonTCB.Click += ATSButtonTCB_Click;
            // 
            // AddCamSplineButton
            // 
            AddCamSplineButton.Location = new Point(8, 200);
            AddCamSplineButton.Name = "AddCamSplineButton";
            AddCamSplineButton.Size = new Size(110, 23);
            AddCamSplineButton.TabIndex = 63;
            AddCamSplineButton.Text = "Add Cam Spline";
            AddCamSplineButton.UseVisualStyleBackColor = true;
            AddCamSplineButton.Click += AddCamSplineButton_Click;
            // 
            // TrgtXYZLabel
            // 
            TrgtXYZLabel.AutoSize = true;
            TrgtXYZLabel.Location = new Point(8, 153);
            TrgtXYZLabel.Name = "TrgtXYZLabel";
            TrgtXYZLabel.Size = new Size(37, 15);
            TrgtXYZLabel.TabIndex = 57;
            TrgtXYZLabel.Text = "Trgt X";
            // 
            // TrgtXYZ
            // 
            TrgtXYZ.Location = new Point(8, 171);
            TrgtXYZ.Name = "TrgtXYZ";
            TrgtXYZ.Size = new Size(239, 23);
            TrgtXYZ.TabIndex = 58;
            TrgtXYZ.Text = "0.00, 0.00, 0.00";
            // 
            // SrcXYZLabel
            // 
            SrcXYZLabel.AutoSize = true;
            SrcXYZLabel.Location = new Point(8, 109);
            SrcXYZLabel.Name = "SrcXYZLabel";
            SrcXYZLabel.Size = new Size(33, 15);
            SrcXYZLabel.TabIndex = 51;
            SrcXYZLabel.Text = "Src X";
            // 
            // SrcXYZ
            // 
            SrcXYZ.Location = new Point(8, 127);
            SrcXYZ.Name = "SrcXYZ";
            SrcXYZ.Size = new Size(239, 23);
            SrcXYZ.TabIndex = 52;
            SrcXYZ.Text = "0.00, 0.00, 0.00";
            // 
            // AddTCBButton
            // 
            AddTCBButton.Location = new Point(8, 57);
            AddTCBButton.Name = "AddTCBButton";
            AddTCBButton.Size = new Size(90, 23);
            AddTCBButton.TabIndex = 50;
            AddTCBButton.Text = "Add TCB";
            AddTCBButton.UseVisualStyleBackColor = true;
            AddTCBButton.Click += AddTCBButton_Click;
            // 
            // TCBSplineW2Label
            // 
            TCBSplineW2Label.AutoSize = true;
            TCBSplineW2Label.Location = new Point(137, 10);
            TCBSplineW2Label.Name = "TCBSplineW2Label";
            TCBSplineW2Label.Size = new Size(77, 15);
            TCBSplineW2Label.TabIndex = 49;
            TCBSplineW2Label.Text = "TCB Weight 2";
            // 
            // TCBSplineW2
            // 
            TCBSplineW2.Location = new Point(137, 28);
            TCBSplineW2.Name = "TCBSplineW2";
            TCBSplineW2.Size = new Size(110, 23);
            TCBSplineW2.TabIndex = 48;
            TCBSplineW2.Text = "1.00";
            // 
            // TCBSplineW1Label
            // 
            TCBSplineW1Label.AutoSize = true;
            TCBSplineW1Label.Location = new Point(8, 10);
            TCBSplineW1Label.Name = "TCBSplineW1Label";
            TCBSplineW1Label.Size = new Size(77, 15);
            TCBSplineW1Label.TabIndex = 46;
            TCBSplineW1Label.Text = "TCB Weight 1";
            // 
            // TCBSplineW1
            // 
            TCBSplineW1.Location = new Point(8, 28);
            TCBSplineW1.Name = "TCBSplineW1";
            TCBSplineW1.Size = new Size(110, 23);
            TCBSplineW1.TabIndex = 47;
            TCBSplineW1.Text = "0.00";
            // 
            // CamSplineList
            // 
            CamSplineList.FormattingEnabled = true;
            CamSplineList.ItemHeight = 15;
            CamSplineList.Location = new Point(253, 109);
            CamSplineList.Name = "CamSplineList";
            CamSplineList.Size = new Size(249, 109);
            CamSplineList.TabIndex = 45;
            CamSplineList.SelectedIndexChanged += CamSplineList_SelectedIndexChanged;
            CamSplineList.KeyDown += RemoveSelected;
            // 
            // TCBInfoList
            // 
            TCBInfoList.FormattingEnabled = true;
            TCBInfoList.ItemHeight = 15;
            TCBInfoList.Location = new Point(253, 10);
            TCBInfoList.Name = "TCBInfoList";
            TCBInfoList.Size = new Size(249, 94);
            TCBInfoList.TabIndex = 44;
            TCBInfoList.SelectedIndexChanged += TCBInfoList_SelectedIndexChanged;
            TCBInfoList.KeyDown += RemoveSelected;
            // 
            // ForceLengthCheck
            // 
            ForceLengthCheck.Appearance = Appearance.Button;
            ForceLengthCheck.Location = new Point(137, 113);
            ForceLengthCheck.Name = "ForceLengthCheck";
            ForceLengthCheck.Size = new Size(23, 23);
            ForceLengthCheck.TabIndex = 23;
            ForceLengthCheck.UseVisualStyleBackColor = true;
            // 
            // ForceLengthLabel
            // 
            ForceLengthLabel.AutoSize = true;
            ForceLengthLabel.Location = new Point(166, 117);
            ForceLengthLabel.Name = "ForceLengthLabel";
            ForceLengthLabel.Size = new Size(81, 15);
            ForceLengthLabel.TabIndex = 22;
            ForceLengthLabel.Text = "Force Length?";
            // 
            // CamTimeLabel
            // 
            CamTimeLabel.AutoSize = true;
            CamTimeLabel.Location = new Point(8, 95);
            CamTimeLabel.Name = "CamTimeLabel";
            CamTimeLabel.Size = new Size(61, 15);
            CamTimeLabel.TabIndex = 20;
            CamTimeLabel.Text = "Cam Time";
            // 
            // CamTime
            // 
            CamTime.Location = new Point(8, 113);
            CamTime.Name = "CamTime";
            CamTime.Size = new Size(110, 23);
            CamTime.TabIndex = 21;
            CamTime.Text = "5.00";
            // 
            // FarPlaneLabel
            // 
            FarPlaneLabel.AutoSize = true;
            FarPlaneLabel.Location = new Point(137, 51);
            FarPlaneLabel.Name = "FarPlaneLabel";
            FarPlaneLabel.Size = new Size(55, 15);
            FarPlaneLabel.TabIndex = 19;
            FarPlaneLabel.Text = "Far Plane";
            // 
            // FarPlane
            // 
            FarPlane.Location = new Point(137, 69);
            FarPlane.Name = "FarPlane";
            FarPlane.Size = new Size(110, 23);
            FarPlane.TabIndex = 18;
            FarPlane.Text = "1000000.00";
            // 
            // CameraList
            // 
            CameraList.FormattingEnabled = true;
            CameraList.ItemHeight = 15;
            CameraList.Location = new Point(253, 10);
            CameraList.Name = "CameraList";
            CameraList.Size = new Size(249, 154);
            CameraList.TabIndex = 17;
            CameraList.SelectedIndexChanged += CameraList_SelectedIndexChanged;
            CameraList.KeyDown += RemoveSelected;
            // 
            // AddCameraButton
            // 
            AddCameraButton.Location = new Point(8, 142);
            AddCameraButton.Name = "AddCameraButton";
            AddCameraButton.Size = new Size(90, 23);
            AddCameraButton.TabIndex = 16;
            AddCameraButton.Text = "Add Camera";
            AddCameraButton.UseVisualStyleBackColor = true;
            AddCameraButton.Click += AddCameraButton_Click;
            // 
            // NearPlaneLabel
            // 
            NearPlaneLabel.AutoSize = true;
            NearPlaneLabel.Location = new Point(8, 51);
            NearPlaneLabel.Name = "NearPlaneLabel";
            NearPlaneLabel.Size = new Size(64, 15);
            NearPlaneLabel.TabIndex = 14;
            NearPlaneLabel.Text = "Near Plane";
            // 
            // NearPlane
            // 
            NearPlane.Location = new Point(8, 69);
            NearPlane.Name = "NearPlane";
            NearPlane.Size = new Size(110, 23);
            NearPlane.TabIndex = 15;
            NearPlane.Text = "10.00";
            // 
            // FOVLabel
            // 
            FOVLabel.AutoSize = true;
            FOVLabel.Location = new Point(8, 7);
            FOVLabel.Name = "FOVLabel";
            FOVLabel.Size = new Size(29, 15);
            FOVLabel.TabIndex = 12;
            FOVLabel.Text = "FOV";
            // 
            // FOV
            // 
            FOV.Location = new Point(8, 25);
            FOV.Name = "FOV";
            FOV.Size = new Size(239, 23);
            FOV.TabIndex = 13;
            FOV.Text = "0.97";
            // 
            // PhonemeTab
            // 
            PhonemeTab.Controls.Add(PhonemePhraseLabel);
            PhonemeTab.Controls.Add(PhonemePhraseCombo);
            PhonemeTab.Controls.Add(ATSButtonPhoneme);
            PhonemeTab.Controls.Add(SubtitleFileName);
            PhonemeTab.Controls.Add(SubtitleFileNameLabel);
            PhonemeTab.Controls.Add(OutTimeLabel);
            PhonemeTab.Controls.Add(OutTime);
            PhonemeTab.Controls.Add(InTimeLabel);
            PhonemeTab.Controls.Add(InTime);
            PhonemeTab.Controls.Add(SubtitleNrLabel);
            PhonemeTab.Controls.Add(SubtitleNr);
            PhonemeTab.Controls.Add(PhonemeNameLabel);
            PhonemeTab.Controls.Add(PhonemeName);
            PhonemeTab.Location = new Point(4, 24);
            PhonemeTab.Name = "PhonemeTab";
            PhonemeTab.Padding = new Padding(3);
            PhonemeTab.Size = new Size(510, 403);
            PhonemeTab.TabIndex = 1;
            PhonemeTab.Text = "Phoneme";
            PhonemeTab.UseVisualStyleBackColor = true;
            // 
            // ATSButtonPhoneme
            // 
            ATSButtonPhoneme.Location = new Point(8, 141);
            ATSButtonPhoneme.Name = "ATSButtonPhoneme";
            ATSButtonPhoneme.Size = new Size(117, 23);
            ATSButtonPhoneme.TabIndex = 47;
            ATSButtonPhoneme.Text = "Apply To Selected";
            ATSButtonPhoneme.UseVisualStyleBackColor = true;
            ATSButtonPhoneme.Click += ATSButtonPhoneme_Click;
            // 
            // SubtitleFileName
            // 
            SubtitleFileName.Location = new Point(8, 362);
            SubtitleFileName.Name = "SubtitleFileName";
            SubtitleFileName.Size = new Size(239, 23);
            SubtitleFileName.TabIndex = 7;
            // 
            // SubtitleFileNameLabel
            // 
            SubtitleFileNameLabel.AutoSize = true;
            SubtitleFileNameLabel.Location = new Point(8, 344);
            SubtitleFileNameLabel.Name = "SubtitleFileNameLabel";
            SubtitleFileNameLabel.Size = new Size(103, 15);
            SubtitleFileNameLabel.TabIndex = 6;
            SubtitleFileNameLabel.Text = "Subtitle File Name";
            // 
            // OutTimeLabel
            // 
            OutTimeLabel.AutoSize = true;
            OutTimeLabel.Location = new Point(137, 94);
            OutTimeLabel.Name = "OutTimeLabel";
            OutTimeLabel.Size = new Size(56, 15);
            OutTimeLabel.TabIndex = 21;
            OutTimeLabel.Text = "Out Time";
            // 
            // OutTime
            // 
            OutTime.Location = new Point(137, 112);
            OutTime.Name = "OutTime";
            OutTime.Size = new Size(110, 23);
            OutTime.TabIndex = 20;
            OutTime.Text = "200";
            // 
            // InTimeLabel
            // 
            InTimeLabel.AutoSize = true;
            InTimeLabel.Location = new Point(8, 94);
            InTimeLabel.Name = "InTimeLabel";
            InTimeLabel.Size = new Size(46, 15);
            InTimeLabel.TabIndex = 18;
            InTimeLabel.Text = "In Time";
            // 
            // InTime
            // 
            InTime.Location = new Point(8, 112);
            InTime.Name = "InTime";
            InTime.Size = new Size(110, 23);
            InTime.TabIndex = 19;
            InTime.Text = "200";
            // 
            // SubtitleNrLabel
            // 
            SubtitleNrLabel.AutoSize = true;
            SubtitleNrLabel.Location = new Point(8, 50);
            SubtitleNrLabel.Name = "SubtitleNrLabel";
            SubtitleNrLabel.Size = new Size(63, 15);
            SubtitleNrLabel.TabIndex = 14;
            SubtitleNrLabel.Text = "Subtitle Nr";
            // 
            // SubtitleNr
            // 
            SubtitleNr.Location = new Point(8, 68);
            SubtitleNr.Name = "SubtitleNr";
            SubtitleNr.Size = new Size(239, 23);
            SubtitleNr.TabIndex = 15;
            SubtitleNr.Text = "0";
            // 
            // PhonemeNameLabel
            // 
            PhonemeNameLabel.AutoSize = true;
            PhonemeNameLabel.Location = new Point(8, 6);
            PhonemeNameLabel.Name = "PhonemeNameLabel";
            PhonemeNameLabel.Size = new Size(93, 15);
            PhonemeNameLabel.TabIndex = 12;
            PhonemeNameLabel.Text = "Phoneme Name";
            // 
            // PhonemeName
            // 
            PhonemeName.Location = new Point(8, 24);
            PhonemeName.Name = "PhonemeName";
            PhonemeName.Size = new Size(239, 23);
            PhonemeName.TabIndex = 13;
            // 
            // PhraseTab
            // 
            PhraseTab.Controls.Add(ATSButtonPhrase);
            PhraseTab.Controls.Add(EffectDelayLabel);
            PhraseTab.Controls.Add(EffectDelay);
            PhraseTab.Controls.Add(EffectParam3);
            PhraseTab.Controls.Add(EffectParam2);
            PhraseTab.Controls.Add(AddPhraseButton);
            PhraseTab.Controls.Add(CameraCombo);
            PhraseTab.Controls.Add(PhraseList);
            PhraseTab.Controls.Add(EffectParamsLabel);
            PhraseTab.Controls.Add(EffectParam1);
            PhraseTab.Controls.Add(CameraLabel);
            PhraseTab.Location = new Point(4, 24);
            PhraseTab.Name = "PhraseTab";
            PhraseTab.Size = new Size(510, 403);
            PhraseTab.TabIndex = 5;
            PhraseTab.Text = "Phrase";
            PhraseTab.UseVisualStyleBackColor = true;
            // 
            // ATSButtonPhrase
            // 
            ATSButtonPhrase.Location = new Point(130, 202);
            ATSButtonPhrase.Name = "ATSButtonPhrase";
            ATSButtonPhrase.Size = new Size(117, 23);
            ATSButtonPhrase.TabIndex = 47;
            ATSButtonPhrase.Text = "Apply To Selected";
            ATSButtonPhrase.UseVisualStyleBackColor = true;
            ATSButtonPhrase.Click += ATSButtonPhrase_Click;
            // 
            // EffectDelayLabel
            // 
            EffectDelayLabel.AutoSize = true;
            EffectDelayLabel.Location = new Point(8, 155);
            EffectDelayLabel.Name = "EffectDelayLabel";
            EffectDelayLabel.Size = new Size(69, 15);
            EffectDelayLabel.TabIndex = 27;
            EffectDelayLabel.Text = "Effect Delay";
            // 
            // EffectDelay
            // 
            EffectDelay.Location = new Point(8, 173);
            EffectDelay.Name = "EffectDelay";
            EffectDelay.Size = new Size(239, 23);
            EffectDelay.TabIndex = 28;
            EffectDelay.Text = "0";
            // 
            // EffectParam3
            // 
            EffectParam3.Location = new Point(8, 129);
            EffectParam3.Name = "EffectParam3";
            EffectParam3.Size = new Size(239, 23);
            EffectParam3.TabIndex = 26;
            // 
            // EffectParam2
            // 
            EffectParam2.Location = new Point(8, 100);
            EffectParam2.Name = "EffectParam2";
            EffectParam2.Size = new Size(239, 23);
            EffectParam2.TabIndex = 25;
            EffectParam2.Text = "subtype = -1";
            // 
            // AddPhraseButton
            // 
            AddPhraseButton.Location = new Point(8, 202);
            AddPhraseButton.Name = "AddPhraseButton";
            AddPhraseButton.Size = new Size(88, 23);
            AddPhraseButton.TabIndex = 24;
            AddPhraseButton.Text = "Add Phrase";
            AddPhraseButton.UseVisualStyleBackColor = true;
            AddPhraseButton.Click += AddPhraseButton_Click;
            // 
            // CameraCombo
            // 
            CameraCombo.FormattingEnabled = true;
            CameraCombo.Location = new Point(8, 27);
            CameraCombo.Name = "CameraCombo";
            CameraCombo.Size = new Size(239, 23);
            CameraCombo.TabIndex = 23;
            // 
            // PhraseList
            // 
            PhraseList.FormattingEnabled = true;
            PhraseList.ItemHeight = 15;
            PhraseList.Location = new Point(253, 9);
            PhraseList.Name = "PhraseList";
            PhraseList.Size = new Size(249, 379);
            PhraseList.TabIndex = 22;
            PhraseList.SelectedIndexChanged += PhraseList_SelectedIndexChanged;
            PhraseList.KeyDown += RemoveSelected;
            // 
            // EffectParamsLabel
            // 
            EffectParamsLabel.AutoSize = true;
            EffectParamsLabel.Location = new Point(8, 53);
            EffectParamsLabel.Name = "EffectParamsLabel";
            EffectParamsLabel.Size = new Size(79, 15);
            EffectParamsLabel.TabIndex = 20;
            EffectParamsLabel.Text = "Effect Params";
            // 
            // EffectParam1
            // 
            EffectParam1.Location = new Point(8, 71);
            EffectParam1.Name = "EffectParam1";
            EffectParam1.Size = new Size(239, 23);
            EffectParam1.TabIndex = 21;
            EffectParam1.Text = "Nothing";
            // 
            // CameraLabel
            // 
            CameraLabel.AutoSize = true;
            CameraLabel.Location = new Point(8, 9);
            CameraLabel.Name = "CameraLabel";
            CameraLabel.Size = new Size(48, 15);
            CameraLabel.TabIndex = 18;
            CameraLabel.Text = "Camera";
            // 
            // CellTab
            // 
            CellTab.Controls.Add(CellPanel);
            CellTab.Controls.Add(PhraseCombo);
            CellTab.Controls.Add(PhraseLabel);
            CellTab.Controls.Add(ActorCombo);
            CellTab.Controls.Add(ActorLabel);
            CellTab.Location = new Point(4, 24);
            CellTab.Name = "CellTab";
            CellTab.Size = new Size(510, 403);
            CellTab.TabIndex = 2;
            CellTab.Text = "Cell";
            CellTab.UseVisualStyleBackColor = true;
            // 
            // CellPanel
            // 
            CellPanel.Controls.Add(ActorRot);
            CellPanel.Controls.Add(ApplyCellButton);
            CellPanel.Controls.Add(RotLabel);
            CellPanel.Controls.Add(ActorPos);
            CellPanel.Controls.Add(PosLabel);
            CellPanel.Controls.Add(FitBodyAnimCheck);
            CellPanel.Controls.Add(BodyAnim);
            CellPanel.Controls.Add(BodyAnimLabel);
            CellPanel.Controls.Add(BodyType);
            CellPanel.Controls.Add(BodyTypeLabel);
            CellPanel.Controls.Add(FitHeadAnimCheck);
            CellPanel.Controls.Add(HeadAnim);
            CellPanel.Controls.Add(HeadAnimLabel);
            CellPanel.Controls.Add(HeadType);
            CellPanel.Controls.Add(HeadTypeLabel);
            CellPanel.Controls.Add(LipScaler);
            CellPanel.Controls.Add(LipScalerLabel);
            CellPanel.Controls.Add(LipAnimName);
            CellPanel.Controls.Add(SpeakingCheck);
            CellPanel.Controls.Add(LipAnimLabel);
            CellPanel.Location = new Point(8, 100);
            CellPanel.Name = "CellPanel";
            CellPanel.Size = new Size(494, 300);
            CellPanel.TabIndex = 29;
            // 
            // ActorRot
            // 
            ActorRot.Location = new Point(25, 235);
            ActorRot.Name = "ActorRot";
            ActorRot.Size = new Size(432, 23);
            ActorRot.TabIndex = 54;
            ActorRot.Text = "0.00, 0.00, 0.00";
            // 
            // ApplyCellButton
            // 
            ApplyCellButton.Location = new Point(25, 264);
            ApplyCellButton.Name = "ApplyCellButton";
            ApplyCellButton.Size = new Size(88, 23);
            ApplyCellButton.TabIndex = 52;
            ApplyCellButton.Text = "Apply Cell";
            ApplyCellButton.UseVisualStyleBackColor = true;
            ApplyCellButton.Click += ApplyCellButton_Click;
            // 
            // RotLabel
            // 
            RotLabel.AutoSize = true;
            RotLabel.Location = new Point(14, 217);
            RotLabel.Name = "RotLabel";
            RotLabel.Size = new Size(57, 15);
            RotLabel.TabIndex = 48;
            RotLabel.Text = "Actor Rot";
            // 
            // ActorPos
            // 
            ActorPos.Location = new Point(25, 191);
            ActorPos.Name = "ActorPos";
            ActorPos.Size = new Size(432, 23);
            ActorPos.TabIndex = 45;
            ActorPos.Text = "0.00, 0.00, 0.00";
            // 
            // PosLabel
            // 
            PosLabel.AutoSize = true;
            PosLabel.Location = new Point(14, 173);
            PosLabel.Name = "PosLabel";
            PosLabel.Size = new Size(58, 15);
            PosLabel.TabIndex = 44;
            PosLabel.Text = "Actor Pos";
            // 
            // FitBodyAnimCheck
            // 
            FitBodyAnimCheck.AutoSize = true;
            FitBodyAnimCheck.Location = new Point(256, 135);
            FitBodyAnimCheck.Name = "FitBodyAnimCheck";
            FitBodyAnimCheck.Size = new Size(129, 19);
            FitBodyAnimCheck.TabIndex = 43;
            FitBodyAnimCheck.Text = "Fit Anim To Phrase?";
            FitBodyAnimCheck.UseVisualStyleBackColor = true;
            // 
            // BodyAnim
            // 
            BodyAnim.Location = new Point(341, 106);
            BodyAnim.Name = "BodyAnim";
            BodyAnim.Size = new Size(140, 23);
            BodyAnim.TabIndex = 42;
            // 
            // BodyAnimLabel
            // 
            BodyAnimLabel.AutoSize = true;
            BodyAnimLabel.Location = new Point(245, 109);
            BodyAnimLabel.Name = "BodyAnimLabel";
            BodyAnimLabel.Size = new Size(66, 15);
            BodyAnimLabel.TabIndex = 41;
            BodyAnimLabel.Text = "Body Anim";
            // 
            // BodyType
            // 
            BodyType.Location = new Point(341, 77);
            BodyType.Name = "BodyType";
            BodyType.Size = new Size(140, 23);
            BodyType.TabIndex = 40;
            BodyType.Text = "1";
            // 
            // BodyTypeLabel
            // 
            BodyTypeLabel.AutoSize = true;
            BodyTypeLabel.Location = new Point(245, 80);
            BodyTypeLabel.Name = "BodyTypeLabel";
            BodyTypeLabel.Size = new Size(61, 15);
            BodyTypeLabel.TabIndex = 39;
            BodyTypeLabel.Text = "Body Type";
            // 
            // FitHeadAnimCheck
            // 
            FitHeadAnimCheck.AutoSize = true;
            FitHeadAnimCheck.Location = new Point(14, 135);
            FitHeadAnimCheck.Name = "FitHeadAnimCheck";
            FitHeadAnimCheck.Size = new Size(129, 19);
            FitHeadAnimCheck.TabIndex = 38;
            FitHeadAnimCheck.Text = "Fit Anim To Phrase?";
            FitHeadAnimCheck.UseVisualStyleBackColor = true;
            // 
            // HeadAnim
            // 
            HeadAnim.Location = new Point(99, 106);
            HeadAnim.Name = "HeadAnim";
            HeadAnim.Size = new Size(140, 23);
            HeadAnim.TabIndex = 37;
            // 
            // HeadAnimLabel
            // 
            HeadAnimLabel.AutoSize = true;
            HeadAnimLabel.Location = new Point(3, 109);
            HeadAnimLabel.Name = "HeadAnimLabel";
            HeadAnimLabel.Size = new Size(67, 15);
            HeadAnimLabel.TabIndex = 36;
            HeadAnimLabel.Text = "Head Anim";
            // 
            // HeadType
            // 
            HeadType.Location = new Point(99, 77);
            HeadType.Name = "HeadType";
            HeadType.Size = new Size(140, 23);
            HeadType.TabIndex = 35;
            HeadType.Text = "1";
            // 
            // HeadTypeLabel
            // 
            HeadTypeLabel.AutoSize = true;
            HeadTypeLabel.Location = new Point(3, 80);
            HeadTypeLabel.Name = "HeadTypeLabel";
            HeadTypeLabel.Size = new Size(62, 15);
            HeadTypeLabel.TabIndex = 34;
            HeadTypeLabel.Text = "Head Type";
            // 
            // LipScaler
            // 
            LipScaler.Location = new Point(99, 32);
            LipScaler.Name = "LipScaler";
            LipScaler.Size = new Size(140, 23);
            LipScaler.TabIndex = 33;
            LipScaler.Text = "128";
            // 
            // LipScalerLabel
            // 
            LipScalerLabel.AutoSize = true;
            LipScalerLabel.Location = new Point(3, 35);
            LipScalerLabel.Name = "LipScalerLabel";
            LipScalerLabel.Size = new Size(57, 15);
            LipScalerLabel.TabIndex = 32;
            LipScalerLabel.Text = "Lip Scaler";
            // 
            // LipAnimName
            // 
            LipAnimName.Location = new Point(99, 3);
            LipAnimName.Name = "LipAnimName";
            LipAnimName.Size = new Size(140, 23);
            LipAnimName.TabIndex = 31;
            // 
            // SpeakingCheck
            // 
            SpeakingCheck.AutoSize = true;
            SpeakingCheck.Location = new Point(245, 5);
            SpeakingCheck.Name = "SpeakingCheck";
            SpeakingCheck.Size = new Size(79, 19);
            SpeakingCheck.TabIndex = 0;
            SpeakingCheck.Text = "Speaking?";
            SpeakingCheck.UseVisualStyleBackColor = true;
            // 
            // LipAnimLabel
            // 
            LipAnimLabel.AutoSize = true;
            LipAnimLabel.Location = new Point(3, 6);
            LipAnimLabel.Name = "LipAnimLabel";
            LipAnimLabel.Size = new Size(55, 15);
            LipAnimLabel.TabIndex = 30;
            LipAnimLabel.Text = "Lip Anim";
            // 
            // PhraseCombo
            // 
            PhraseCombo.FormattingEnabled = true;
            PhraseCombo.Location = new Point(8, 71);
            PhraseCombo.Name = "PhraseCombo";
            PhraseCombo.Size = new Size(239, 23);
            PhraseCombo.TabIndex = 27;
            PhraseCombo.SelectedIndexChanged += CellSelectChanged;
            // 
            // PhraseLabel
            // 
            PhraseLabel.AutoSize = true;
            PhraseLabel.Location = new Point(8, 53);
            PhraseLabel.Name = "PhraseLabel";
            PhraseLabel.Size = new Size(42, 15);
            PhraseLabel.TabIndex = 26;
            PhraseLabel.Text = "Phrase";
            // 
            // ActorCombo
            // 
            ActorCombo.FormattingEnabled = true;
            ActorCombo.Location = new Point(8, 27);
            ActorCombo.Name = "ActorCombo";
            ActorCombo.Size = new Size(239, 23);
            ActorCombo.TabIndex = 25;
            ActorCombo.SelectedIndexChanged += CellSelectChanged;
            // 
            // ActorLabel
            // 
            ActorLabel.AutoSize = true;
            ActorLabel.Location = new Point(8, 9);
            ActorLabel.Name = "ActorLabel";
            ActorLabel.Size = new Size(36, 15);
            ActorLabel.TabIndex = 24;
            ActorLabel.Text = "Actor";
            // 
            // OutputTab
            // 
            OutputTab.Controls.Add(OutputText);
            OutputTab.Location = new Point(4, 24);
            OutputTab.Name = "OutputTab";
            OutputTab.Size = new Size(510, 403);
            OutputTab.TabIndex = 3;
            OutputTab.Text = "Output";
            OutputTab.UseVisualStyleBackColor = true;
            // 
            // OutputText
            // 
            OutputText.Dock = DockStyle.Fill;
            OutputText.Location = new Point(0, 0);
            OutputText.Name = "OutputText";
            OutputText.Size = new Size(510, 403);
            OutputText.TabIndex = 0;
            OutputText.Text = "";
            // 
            // WarningMessage
            // 
            WarningMessage.AutoSize = true;
            WarningMessage.Location = new Point(12, 434);
            WarningMessage.Name = "WarningMessage";
            WarningMessage.Size = new Size(0, 15);
            WarningMessage.TabIndex = 6;
            // 
            // PhonemePhraseCombo
            // 
            PhonemePhraseCombo.FormattingEnabled = true;
            PhonemePhraseCombo.Location = new Point(263, 24);
            PhonemePhraseCombo.Name = "PhonemePhraseCombo";
            PhonemePhraseCombo.Size = new Size(239, 23);
            PhonemePhraseCombo.TabIndex = 48;
            PhonemePhraseCombo.SelectedIndexChanged += PhonemePhraseCombo_SelectedIndexChanged;
            // 
            // PhonemePhraseLabel
            // 
            PhonemePhraseLabel.AutoSize = true;
            PhonemePhraseLabel.Location = new Point(263, 6);
            PhonemePhraseLabel.Name = "PhonemePhraseLabel";
            PhonemePhraseLabel.Size = new Size(42, 15);
            PhonemePhraseLabel.TabIndex = 49;
            PhonemePhraseLabel.Text = "Phrase";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 461);
            Controls.Add(WarningMessage);
            Controls.Add(TabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "DLG Editor";
            TabControl.ResumeLayout(false);
            ActorTab.ResumeLayout(false);
            ActorTab.PerformLayout();
            CameraTab.ResumeLayout(false);
            CameraTab.PerformLayout();
            ActiveCameraPanel.ResumeLayout(false);
            ActiveCameraPanel.PerformLayout();
            PhonemeTab.ResumeLayout(false);
            PhonemeTab.PerformLayout();
            PhraseTab.ResumeLayout(false);
            PhraseTab.PerformLayout();
            CellTab.ResumeLayout(false);
            CellTab.PerformLayout();
            CellPanel.ResumeLayout(false);
            CellPanel.PerformLayout();
            OutputTab.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl TabControl;
        private TabPage PhonemeTab;
        private TabPage ActorTab;
        private TabPage CellTab;
        private TabPage OutputTab;
        private TabPage CameraTab;
        private TabPage PhraseTab;
        public ListBox ActorList;
        private Button AddActorButton;
        private Label ActorModelLabel;
        private TextBox ActorModel;
        private Label ActorNameLabel;
        private TextBox ActorName;
        private RichTextBox OutputText;
        private Label FarPlaneLabel;
        private TextBox FarPlane;
        private ListBox CameraList;
        private Button AddCameraButton;
        private Label NearPlaneLabel;
        private TextBox NearPlane;
        private Label FOVLabel;
        private TextBox FOV;
        private Label ForceLengthLabel;
        private Label CamTimeLabel;
        private TextBox CamTime;
        private CheckBox ForceLengthCheck;
        private Panel ActiveCameraPanel;
        private Button AddCamSplineButton;
        private Label TrgtXYZLabel;
        private TextBox TrgtXYZ;
        private Label SrcXYZLabel;
        private TextBox SrcXYZ;
        private Button AddTCBButton;
        private Label TCBSplineW2Label;
        private TextBox TCBSplineW2;
        private Label TCBSplineW1Label;
        private TextBox TCBSplineW1;
        public ListBox CamSplineList;
        public ListBox TCBInfoList;
        private Label SubtitleNrLabel;
        private TextBox SubtitleNr;
        private Label PhonemeNameLabel;
        private TextBox PhonemeName;
        private Label SubtitleFileNameLabel;
        private TextBox SubtitleFileName;
        private Label OutTimeLabel;
        private TextBox OutTime;
        private Label InTimeLabel;
        private TextBox InTime;
        public ListBox PhraseList;
        private Label EffectParamsLabel;
        private TextBox EffectParam1;
        private Label CameraLabel;
        private Button AddPhraseButton;
        private ComboBox CameraCombo;
        private TextBox EffectParam3;
        private TextBox EffectParam2;
        private Label EffectDelayLabel;
        private TextBox EffectDelay;
        private ComboBox PhraseCombo;
        private Label PhraseLabel;
        private ComboBox ActorCombo;
        private Label ActorLabel;
        private Panel CellPanel;
        private CheckBox SpeakingCheck;
        private Label LipAnimLabel;
        private TextBox HeadAnim;
        private Label HeadAnimLabel;
        private TextBox HeadType;
        private Label HeadTypeLabel;
        private TextBox LipScaler;
        private Label LipScalerLabel;
        private TextBox LipAnimName;
        private CheckBox FitHeadAnimCheck;
        private Label RotLabel;
        private TextBox ActorPos;
        private Label PosLabel;
        private CheckBox FitBodyAnimCheck;
        private TextBox BodyAnim;
        private Label BodyAnimLabel;
        private TextBox BodyType;
        private Label BodyTypeLabel;
        private Button ApplyCellButton;
        private TextBox ActorRot;
        private Label WarningMessage;
        private Button ATSButtonActor;
        private Button ATSButtonCamera;
        private Button ATSButtonCamSpline;
        private Button ATSButtonTCB;
        private Button ATSButtonPhoneme;
        private Button ATSButtonPhrase;
        private Label PhonemePhraseLabel;
        private ComboBox PhonemePhraseCombo;
    }
}