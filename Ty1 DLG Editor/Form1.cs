using System.ComponentModel;
using System.Media;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Ty1_DLG_Editor
{
    public partial class Form1 : Form
    {
        private BindingList<Actor> _actors = new();
        private BindingList<Camera> _cameras = new();
        private BindingList<Phoneme> _phonemes = new();
        private BindingList<Phrase> _phrases = new();

        public Form1()
        {
            InitializeComponent();
            ActorList.DataSource = _actors;
            CameraList.DataSource = _cameras;
            PhonemeList.DataSource = _phonemes;
            PhraseList.DataSource = _phrases;
            CameraCombo.DataSource = _cameras;
            ActorCombo.DataSource = _actors;
            PhraseCombo.DataSource = _phrases;
        }

        //ADD BUTTONS

        private void AddActorButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ActorName.Text)
                && !string.IsNullOrWhiteSpace(ActorModel.Text))
            {
                if (!_actors.Any(a => a.Name == ActorName.Text))
                {
                    _actors.Add(new Actor(ActorName.Text, ActorModel.Text));
                    ActorName.Text = "";
                    ActorModel.Text = "";
                    return;
                }
                WarningMessage.Text = "Actor already exists";
                SystemSounds.Asterisk.Play();
                return;
            }
            WarningMessage.Text = "Actor name and model cannot be empty";
            SystemSounds.Asterisk.Play();
        }

        private void AddCameraButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FOV.Text)
                && !string.IsNullOrWhiteSpace(NearPlane.Text)
                && !string.IsNullOrWhiteSpace(FarPlane.Text)
                && !string.IsNullOrWhiteSpace(CamTime.Text))
            {
                int i = 0;
                while (_cameras.Any(x => x.Index == i)) i++;
                _cameras.Add(new Camera(
                    i,
                    float.Parse(FOV.Text),
                    float.Parse(NearPlane.Text),
                    float.Parse(FarPlane.Text),
                    float.Parse(CamTime.Text),
                    ForceLengthCheck.Checked)
                    );
                return;
            }
            WarningMessage.Text = "Camera fields cannot be empty";
            SystemSounds.Asterisk.Play();
        }

        private void AddTCBButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TCBSplineW1.Text)
                && !string.IsNullOrWhiteSpace(TCBSplineW2.Text))
            {
                int i = 0;
                while (_cameras[CameraList.SelectedIndex].TCBInfos.Any(tcb => tcb.Index == i)) i++;
                _cameras[CameraList.SelectedIndex].TCBInfos.Add(new TCBInfo(
                    i,
                    float.Parse(TCBSplineW1.Text),
                    float.Parse(TCBSplineW2.Text)));
                return;
            }
            WarningMessage.Text = "TCB fields cannot be empty";
            SystemSounds.Asterisk.Play();
        }

        private void AddCamSplineButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SrcXYZ.Text)
                && !string.IsNullOrWhiteSpace(TrgtXYZ.Text))
            {
                int i = 0;
                while (_cameras[CameraList.SelectedIndex].CamSplines.Any(tcb => tcb.Index == i)) i++;
                _cameras[CameraList.SelectedIndex].CamSplines.Add(new CamSpline(
                    i,
                    SrcXYZ.Text,
                    TrgtXYZ.Text));
                return;
            }
            WarningMessage.Text = "CamSpline fields cannot be empty";
            SystemSounds.Asterisk.Play();
        }

        private void AddPhonemeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PhonemeName.Text)
                && !string.IsNullOrWhiteSpace(SubtitleNr.Text)
                && !string.IsNullOrWhiteSpace(InTime.Text)
                && !string.IsNullOrWhiteSpace(OutTime.Text))
            {
                _phonemes.Add(new Phoneme(
                    PhonemeName.Text,
                    int.Parse(SubtitleNr.Text),
                    float.Parse(InTime.Text),
                    float.Parse(OutTime.Text)));
                return;
            }
            WarningMessage.Text = "Phoneme fields cannot be empty";
            SystemSounds.Asterisk.Play();
        }

        private void AddPhraseButton_Click(object sender, EventArgs e)
        {
            if (CameraCombo.SelectedItem != null
                && !string.IsNullOrWhiteSpace(EffectDelay.Text))
            {
                int i = 0;
                while (_phrases.Any(p => p.Index == i)) i++;
                List<string> effectParams = new List<string>();
                if (EffectParam1 != null) effectParams.Add(EffectParam1.Text);
                if (EffectParam2 != null) effectParams.Add(EffectParam2.Text);
                if (EffectParam3 != null) effectParams.Add(EffectParam3.Text);
                _phrases.Add(new Phrase(
                    i,
                    CameraCombo.SelectedIndex,
                    effectParams,
                    float.Parse(EffectDelay.Text)));
                foreach (Actor a in _actors)
                {
                    a.Cells.Add(
                        i,
                        new Cell("", 128, "", 1, "", 1, false, false, false, "0.00, 0.00, 0.00", "0.00, 0.00, 0.00"));
                }
                return;
            }
            WarningMessage.Text = "Phrase camera and delay fields cannot be empty";
            SystemSounds.Asterisk.Play();
        }

        //APPLY TO SELECTED BUTTONS

        private void ATSButtonActor_Click(object sender, EventArgs e)
        {
            if (ActorList.SelectedItem == null)
            {
                WarningMessage.Text = "Selected index cannot be null";
                return;
            }
            _actors[ActorList.SelectedIndex].Name = ActorName.Text;
            _actors[ActorList.SelectedIndex].Model = ActorModel.Text;
            ((BindingList<Actor>)ActorList.DataSource).ResetItem(ActorList.SelectedIndex);
            WarningMessage.Text = "Applied current to selected successfully";
        }

        private void ATSButtonCamera_Click(object sender, EventArgs e)
        {
            if (CameraList.SelectedItem == null)
            {
                WarningMessage.Text = "Selected index cannot be null";
                return;
            }
            _cameras[CameraList.SelectedIndex].FOV = float.Parse(FOV.Text);
            _cameras[CameraList.SelectedIndex].NearPlane = float.Parse(NearPlane.Text);
            _cameras[CameraList.SelectedIndex].FarPlane = float.Parse(FarPlane.Text);
            _cameras[CameraList.SelectedIndex].CamTime = float.Parse(CamTime.Text);
            _cameras[CameraList.SelectedIndex].ForceLength = ForceLengthCheck.Checked;
            TCBInfoList.DataSource = _cameras[CameraList.SelectedIndex].TCBInfos;
            ((BindingList<Camera>)CameraList.DataSource).ResetItem(CameraList.SelectedIndex);
            WarningMessage.Text = "Applied current to selected successfully";
        }

        private void ATSButtonTCB_Click(object sender, EventArgs e)
        {
            if (CameraList.SelectedItem == null || TCBInfoList.SelectedItem == null)
            {
                WarningMessage.Text = "Selected index cannot be null";
                return;
            }
            _cameras[CameraList.SelectedIndex].TCBInfos[TCBInfoList.SelectedIndex].Weight1 = float.Parse(TCBSplineW1.Text);
            _cameras[CameraList.SelectedIndex].TCBInfos[TCBInfoList.SelectedIndex].Weight2 = float.Parse(TCBSplineW2.Text);
            ((BindingList<TCBInfo>)TCBInfoList.DataSource).ResetItem(TCBInfoList.SelectedIndex);
            WarningMessage.Text = "Applied current to selected successfully";
        }

        private void ATSButtonCamSpline_Click(object sender, EventArgs e)
        {
            if (CameraList.SelectedItem == null || CamSplineList.SelectedItem == null)
            {
                WarningMessage.Text = "Selected index cannot be null";
                return;
            }
            _cameras[CameraList.SelectedIndex].CamSplines[CamSplineList.SelectedIndex].Source = SrcXYZ.Text;
            _cameras[CameraList.SelectedIndex].CamSplines[CamSplineList.SelectedIndex].Target = TrgtXYZ.Text;
            ((BindingList<TCBInfo>)CamSplineList.DataSource).ResetItem(CamSplineList.SelectedIndex);
            WarningMessage.Text = "Applied current to selected successfully";
        }

        private void ATSButtonPhoneme_Click(object sender, EventArgs e)
        {
            if (PhonemeList.SelectedItem == null)
            {
                WarningMessage.Text = "Selected index cannot be null";
                return;
            }
            _phonemes[PhonemeList.SelectedIndex].Name = PhonemeName.Text;
            _phonemes[PhonemeList.SelectedIndex].SubtitleNr = int.Parse(SubtitleNr.Text);
            _phonemes[PhonemeList.SelectedIndex].InTime = float.Parse(InTime.Text);
            _phonemes[PhonemeList.SelectedIndex].OutTime = float.Parse(OutTime.Text);
            ((BindingList<Phoneme>)PhonemeList.DataSource).ResetItem(PhonemeList.SelectedIndex);
            WarningMessage.Text = "Applied current to selected successfully";
        }

        private void ATSButtonPhrase_Click(object sender, EventArgs e)
        {
            if (PhraseList.SelectedItem == null)
            {
                WarningMessage.Text = "Selected index cannot be null";
                return;
            }
            List<string> effectParams = new List<string>();
            if (EffectParam1 != null) effectParams.Add(EffectParam1.Text);
            if (EffectParam2 != null) effectParams.Add(EffectParam2.Text);
            if (EffectParam3 != null) effectParams.Add(EffectParam3.Text);
            _phrases[PhraseList.SelectedIndex].CamIndex = CameraCombo.SelectedIndex;
            _phrases[PhraseList.SelectedIndex].EffectParams = effectParams;
            _phrases[PhraseList.SelectedIndex].EffectDelay = float.Parse(EffectDelay.Text);
            ((BindingList<Phrase>)PhraseList.DataSource).ResetItem(PhraseList.SelectedIndex);
            WarningMessage.Text = "Applied current to selected successfully";
        }

        //SELECTED INDICES CHANGED

        private void ActorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActorList.SelectedItem == null) return;
            Actor a = (Actor)ActorList.SelectedItem;
            ActorName.Text = a.Name;
            ActorModel.Text = a.Model;
        }

        private void CameraList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CameraList.SelectedItem == null)
            {
                ActiveCameraPanel.Enabled = false;
                return;
            }
            ActiveCameraPanel.Enabled = true;
            Camera c = (Camera)CameraList.SelectedItem;
            FOV.Text = c.FOV.ToString();
            NearPlane.Text = c.NearPlane.ToString();
            FarPlane.Text = c.FarPlane.ToString();
            CamTime.Text = c.CamTime.ToString();
            ForceLengthCheck.Checked = c.ForceLength;
            TCBInfoList.DataSource = c.TCBInfos;
            CamSplineList.DataSource = c.CamSplines;
        }

        private void TCBInfoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CameraList.SelectedItem == null || TCBInfoList.SelectedItem == null)
            {
                return;
            }
            TCBInfo tcb = (TCBInfo)TCBInfoList.SelectedItem;
            TCBSplineW1.Text = tcb.Weight1.ToString();
            TCBSplineW2.Text = tcb.Weight2.ToString();
        }

        private void CamSplineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CameraList.SelectedItem == null || CamSplineList.SelectedItem == null)
            {
                return;
            }
            CamSpline cs = (CamSpline)CamSplineList.SelectedItem;
            SrcXYZ.Text = cs.Source;
            TrgtXYZ.Text = cs.Target;
        }

        private void PhonemeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PhonemeList.SelectedItem == null) return;
            Phoneme p = (Phoneme)PhonemeList.SelectedItem;
            PhonemeName.Text = p.Name;
            SubtitleNr.Text = p.SubtitleNr.ToString();
            InTime.Text = p.InTime.ToString();
            OutTime.Text = p.OutTime.ToString();
        }

        private void PhraseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PhraseList.SelectedItem == null) return;
            Phrase p = (Phrase)PhraseList.SelectedItem;
            CameraCombo.SelectedIndex = p.CamIndex;
            if (p.EffectParams.Count > 0) EffectParam1.Text = p.EffectParams[0];
            if (p.EffectParams.Count > 1) EffectParam2.Text = p.EffectParams[1];
            if (p.EffectParams.Count > 2) EffectParam3.Text = p.EffectParams[2];
            EffectDelay.Text = p.EffectDelay.ToString();
        }

        //REMOVE ITEMS

        private void RemoveSelected(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) && (sender as ListBox).SelectedItem != null)
            {
                Type selectedType = (sender as ListBox).SelectedItem.GetType();
                MethodInfo method = typeof(Form1).GetMethod("RemoveItemFromSource");
                MethodInfo genericMethod = method.MakeGenericMethod(selectedType);
                genericMethod.Invoke(this, new object[] { (sender as ListBox).DataSource, (sender as ListBox).SelectedItem });
            }
        }

        public void RemoveItemFromSource<T>(BindingList<T> bindingList, T item)
        {
            if (item is Phrase)
            {
                foreach (Actor a in _actors)
                {
                    a.Cells.Remove((item as Phrase).Index);
                }
            }
            if (bindingList != null && item != null) bindingList.Remove(item);
        }

        private void CellSelectChanged(object sender, EventArgs e)
        {
            if (ActorCombo.SelectedItem == null || PhraseCombo.SelectedItem == null) return;
            Actor a = (Actor)ActorCombo.SelectedItem;
            if (!a.Cells.ContainsKey(PhraseCombo.SelectedIndex)) return;
            LipAnimName.Text = a.Cells[PhraseCombo.SelectedIndex].LipAnim;
            LipScaler.Text = a.Cells[PhraseCombo.SelectedIndex].LipScaler.ToString();
            HeadAnim.Text = a.Cells[PhraseCombo.SelectedIndex].HeadAnim;
            HeadType.Text = a.Cells[PhraseCombo.SelectedIndex].HeadType.ToString();
            BodyAnim.Text = a.Cells[PhraseCombo.SelectedIndex].BodyAnim;
            BodyType.Text = a.Cells[PhraseCombo.SelectedIndex].BodyType.ToString();
            SpeakingCheck.Checked = a.Cells[PhraseCombo.SelectedIndex].Speaking;
            FitBodyAnimCheck.Checked = a.Cells[PhraseCombo.SelectedIndex].FitBodyAnim;
            FitHeadAnimCheck.Checked = a.Cells[PhraseCombo.SelectedIndex].FitHeadAnim;
            ActorPos.Text = a.Cells[PhraseCombo.SelectedIndex].ActorPos;
            ActorRot.Text = a.Cells[PhraseCombo.SelectedIndex].ActorRot;
        }

        private void ApplyCellButton_Click(object sender, EventArgs e)
        {
            if (ActorCombo.SelectedItem == null || PhraseCombo.SelectedItem == null) return;
            Actor a = (Actor)ActorCombo.SelectedItem;
            if (!a.Cells.ContainsKey(PhraseCombo.SelectedIndex)) return;
            a.Cells[PhraseCombo.SelectedIndex].LipAnim = LipAnimName.Text;
            a.Cells[PhraseCombo.SelectedIndex].LipScaler = int.Parse(LipScaler.Text);
            a.Cells[PhraseCombo.SelectedIndex].HeadAnim = HeadAnim.Text;
            a.Cells[PhraseCombo.SelectedIndex].HeadType = int.Parse(HeadType.Text);
            a.Cells[PhraseCombo.SelectedIndex].BodyAnim = BodyAnim.Text;
            a.Cells[PhraseCombo.SelectedIndex].BodyType = int.Parse(BodyType.Text);
            a.Cells[PhraseCombo.SelectedIndex].Speaking = SpeakingCheck.Checked;
            a.Cells[PhraseCombo.SelectedIndex].FitBodyAnim = FitBodyAnimCheck.Checked;
            a.Cells[PhraseCombo.SelectedIndex].FitHeadAnim = FitHeadAnimCheck.Checked;
            a.Cells[PhraseCombo.SelectedIndex].ActorPos = ActorPos.Text;
            a.Cells[PhraseCombo.SelectedIndex].ActorRot = ActorRot.Text;
            WarningMessage.Text = "Applied current to selected successfully";
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab.Text != "Output") return;
            OutputText.Lines = ParseData();
        }

        private string[] ParseData()
        {
            List<string> output = new();
            output.Add("//Krome Dialog File");
            output.Add("//Created at: " + DateTime.Now.ToString());
            output.Add("//");
            output.Add("[SETUP]");
            if (string.IsNullOrEmpty(SubtitleFileName.Text)) output.Add("//WARNING NO SUBTITLE FILE SPECIFIED");
            else output.Add("SubtitleFile = " + SubtitleFileName.Text);
            output.Add("TotalPhrases = " + _phrases.Count);
            output.Add("");
            output.Add("[PHONEMES]");
            foreach (Phoneme p in _phonemes)
            {
                output.Add("PhonemeName = " + p.Name);
                output.Add("SubtitleNr = " + p.SubtitleNr);
                output.Add("InTime = " + p.InTime.ToString());
                output.Add("OutTime = " + p.OutTime.ToString());
            }
            output.Add("");
            output.Add("[ACTORS]");
            output.Add("Count = " + _actors.Count);
            foreach (Actor a in _actors)
            {
                output.Add("Actor = " + a.Name);
                output.Add("Model = " + a.Model);
            }
            output.Add("");
            output.Add("[CAMERAS]");
            output.Add("Count = " + _cameras.Count);
            foreach (Camera c in _cameras)
            {
                output.Add("FOV = " + c.FOV.ToString());
                output.Add("NearPlane = " + c.NearPlane.ToString());
                output.Add("FarPlane = " + c.FarPlane.ToString());
                output.Add("CamTime = " + c.CamTime.ToString());
                output.Add("ForceLength = " + (c.ForceLength ? 1 : 0));
                output.Add("TCBInfo = " + c.TCBInfos.Count);
                foreach (TCBInfo tcb in c.TCBInfos)
                {
                    output.Add("  spline = " + tcb.Weight1.ToString() + "," + tcb.Weight2.ToString());
                }
                output.Add("CamSplines = " + c.CamSplines.Count);
                foreach (CamSpline cs in c.CamSplines)
                {
                    output.Add("  Spline = " + cs.Source + "," + cs.Target);
                }
            }
            output.Add("");
            output.Add("[CELLS]");
            foreach (Actor a in _actors)
            {
                foreach (Phrase p in _phrases)
                {
                    Cell c = a.Cells[p.Index];
                    output.Add("Speaking = " + (c.Speaking ? 1 : 0));
                    if (string.IsNullOrEmpty(c.LipAnim)) output.Add("//WARNING LIP ANIM IS NULL");
                    else output.Add("LipAnim = " + c.LipAnim);
                    output.Add("LipScaler = " + c.LipScaler.ToString());
                    output.Add("HeadType = " + c.HeadType.ToString());
                    if (string.IsNullOrEmpty(c.LipAnim)) output.Add("//WARNING HEAD ANIM IS NULL");
                    else output.Add("HeadAnim = " + c.HeadAnim);
                    output.Add("FitAnimToPhrase = " + (c.FitHeadAnim ? 1 : 0));
                    output.Add("BodyType = " + c.BodyType.ToString());
                    if (string.IsNullOrEmpty(c.LipAnim)) output.Add("//WARNING BODY ANIM IS NULL");
                    else output.Add("BodyAnim = " + c.BodyAnim);
                    output.Add("FitAnimToPhrase = " + (c.FitBodyAnim ? 1 : 0));
                    output.Add("ActorPos = " + c.ActorPos);
                    output.Add("ActorRot = " + c.ActorRot);
                }
            }
            output.Add("");
            output.Add("[PHRASES]");
            foreach (Phrase p in _phrases)
            {
                output.Add("CameraNr = " + p.CamIndex.ToString());
                output.Add("Effect = " + string.Join(' ', p.EffectParams.ToArray()));
                output.Add("EffectDelay = " + p.EffectDelay);
            }
            output.Add("");
            output.Add("[END]");
            return output.ToArray();
        }
    }
}