namespace InitiativeTracker
{
    partial class FrontEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontEnd));
            lbl_Pokémon = new Label();
            txtbx_Pokéinput = new TextBox();
            lbl_Initiative = new Label();
            txtbx_InitiativeInput = new TextBox();
            btn_NewRound = new Button();
            btn_UseMove = new Button();
            btn_Faint = new Button();
            btn_AddPokemon = new Button();
            panelTurn = new Panel();
            btn_pdb = new Button();
            btn_Bulbapedia = new Button();
            btn_Help = new Button();
            lbl_Turn = new Label();
            lbl_Round = new Label();
            lbl_RoundCount = new Label();
            btn_NextTurn = new Button();
            btn_UpdatePokemon = new Button();
            btn_Reset = new Button();
            lbl_Dex = new Label();
            txtbx_DexInput = new TextBox();
            btn_MoveUp = new Button();
            btn_MoveDown = new Button();
            chkbx_TrickRoom = new CheckBox();
            dgv_Tracker = new DataGridView();
            dgch_Pokemon = new DataGridViewTextBoxColumn();
            dgch_Initiative = new DataGridViewTextBoxColumn();
            dgch_SuccessesNeeded = new DataGridViewTextBoxColumn();
            dgch_Dexterity = new DataGridViewTextBoxColumn();
            dvch_Evaded = new DataGridViewTextBoxColumn();
            dvch_Clashed = new DataGridViewTextBoxColumn();
            btn_Clash = new Button();
            btn_Evade = new Button();
            btn_MoveUndo = new Button();
            btn_ClashUndo = new Button();
            btn_EvadeUndo = new Button();
            panelTurn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Tracker).BeginInit();
            SuspendLayout();
            // 
            // lbl_Pokémon
            // 
            lbl_Pokémon.AutoSize = true;
            lbl_Pokémon.Location = new Point(12, 9);
            lbl_Pokémon.Name = "lbl_Pokémon";
            lbl_Pokémon.Size = new Size(73, 20);
            lbl_Pokémon.TabIndex = 0;
            lbl_Pokémon.Text = "Pokémon:";
            // 
            // txtbx_Pokéinput
            // 
            txtbx_Pokéinput.Location = new Point(88, 6);
            txtbx_Pokéinput.Name = "txtbx_Pokéinput";
            txtbx_Pokéinput.Size = new Size(205, 27);
            txtbx_Pokéinput.TabIndex = 1;
            // 
            // lbl_Initiative
            // 
            lbl_Initiative.AutoSize = true;
            lbl_Initiative.Location = new Point(13, 47);
            lbl_Initiative.Name = "lbl_Initiative";
            lbl_Initiative.Size = new Size(69, 20);
            lbl_Initiative.TabIndex = 2;
            lbl_Initiative.Text = "Initiative:";
            // 
            // txtbx_InitiativeInput
            // 
            txtbx_InitiativeInput.BackColor = SystemColors.Window;
            txtbx_InitiativeInput.Location = new Point(88, 44);
            txtbx_InitiativeInput.Name = "txtbx_InitiativeInput";
            txtbx_InitiativeInput.Size = new Size(35, 27);
            txtbx_InitiativeInput.TabIndex = 3;
            // 
            // btn_NewRound
            // 
            btn_NewRound.BackColor = Color.Gold;
            btn_NewRound.Location = new Point(74, 160);
            btn_NewRound.Name = "btn_NewRound";
            btn_NewRound.Size = new Size(121, 47);
            btn_NewRound.TabIndex = 5;
            btn_NewRound.Text = "Start!";
            btn_NewRound.UseVisualStyleBackColor = false;
            btn_NewRound.Click += btn_NewRound_Click;
            // 
            // btn_UseMove
            // 
            btn_UseMove.BackColor = Color.Peru;
            btn_UseMove.Location = new Point(12, 213);
            btn_UseMove.Name = "btn_UseMove";
            btn_UseMove.Size = new Size(204, 38);
            btn_UseMove.TabIndex = 6;
            btn_UseMove.Text = "Use Move";
            btn_UseMove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_UseMove.UseVisualStyleBackColor = false;
            btn_UseMove.Click += btn_UseAction_Click;
            // 
            // btn_Faint
            // 
            btn_Faint.BackColor = Color.Red;
            btn_Faint.Location = new Point(12, 125);
            btn_Faint.Name = "btn_Faint";
            btn_Faint.Size = new Size(135, 29);
            btn_Faint.TabIndex = 7;
            btn_Faint.Text = "Faint";
            btn_Faint.UseVisualStyleBackColor = false;
            btn_Faint.Click += btn_FaintClick;
            // 
            // btn_AddPokemon
            // 
            btn_AddPokemon.BackColor = Color.LawnGreen;
            btn_AddPokemon.Location = new Point(12, 90);
            btn_AddPokemon.Name = "btn_AddPokemon";
            btn_AddPokemon.Size = new Size(135, 29);
            btn_AddPokemon.TabIndex = 8;
            btn_AddPokemon.Text = "Add Pokémon";
            btn_AddPokemon.UseVisualStyleBackColor = false;
            btn_AddPokemon.Click += btn_AddPokemon_Click;
            // 
            // panelTurn
            // 
            panelTurn.BackColor = SystemColors.ActiveCaption;
            panelTurn.Controls.Add(btn_pdb);
            panelTurn.Controls.Add(btn_Bulbapedia);
            panelTurn.Controls.Add(btn_Help);
            panelTurn.Controls.Add(lbl_Turn);
            panelTurn.Location = new Point(12, 445);
            panelTurn.Name = "panelTurn";
            panelTurn.Size = new Size(1008, 179);
            panelTurn.TabIndex = 9;
            // 
            // btn_pdb
            // 
            btn_pdb.BackColor = SystemColors.ActiveBorder;
            btn_pdb.Location = new Point(3, 112);
            btn_pdb.Name = "btn_pdb";
            btn_pdb.Size = new Size(108, 29);
            btn_pdb.TabIndex = 3;
            btn_pdb.Text = "PokemonDB";
            btn_pdb.UseVisualStyleBackColor = false;
            btn_pdb.Click += btn_pdb_Click;
            // 
            // btn_Bulbapedia
            // 
            btn_Bulbapedia.BackColor = Color.Chartreuse;
            btn_Bulbapedia.Location = new Point(3, 147);
            btn_Bulbapedia.Name = "btn_Bulbapedia";
            btn_Bulbapedia.Size = new Size(108, 29);
            btn_Bulbapedia.TabIndex = 2;
            btn_Bulbapedia.Text = "Bulbapedia";
            btn_Bulbapedia.UseVisualStyleBackColor = false;
            btn_Bulbapedia.Click += btn_Bulbapedia_Click;
            // 
            // btn_Help
            // 
            btn_Help.BackColor = Color.Transparent;
            btn_Help.Location = new Point(982, 147);
            btn_Help.Name = "btn_Help";
            btn_Help.Size = new Size(23, 29);
            btn_Help.TabIndex = 1;
            btn_Help.Text = "?";
            btn_Help.UseVisualStyleBackColor = false;
            btn_Help.Click += btn_Help_Click;
            // 
            // lbl_Turn
            // 
            lbl_Turn.AutoSize = true;
            lbl_Turn.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Turn.Location = new Point(397, 85);
            lbl_Turn.Name = "lbl_Turn";
            lbl_Turn.Size = new Size(225, 29);
            lbl_Turn.TabIndex = 0;
            lbl_Turn.Text = "Whose Turn Is It?";
            // 
            // lbl_Round
            // 
            lbl_Round.AutoSize = true;
            lbl_Round.Location = new Point(13, 374);
            lbl_Round.Name = "lbl_Round";
            lbl_Round.Size = new Size(55, 20);
            lbl_Round.TabIndex = 11;
            lbl_Round.Text = "Round:";
            // 
            // lbl_RoundCount
            // 
            lbl_RoundCount.AutoSize = true;
            lbl_RoundCount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_RoundCount.Location = new Point(74, 365);
            lbl_RoundCount.Name = "lbl_RoundCount";
            lbl_RoundCount.Size = new Size(26, 31);
            lbl_RoundCount.TabIndex = 12;
            lbl_RoundCount.Text = "0";
            // 
            // btn_NextTurn
            // 
            btn_NextTurn.BackColor = Color.PapayaWhip;
            btn_NextTurn.Location = new Point(153, 125);
            btn_NextTurn.Name = "btn_NextTurn";
            btn_NextTurn.Size = new Size(140, 29);
            btn_NextTurn.TabIndex = 13;
            btn_NextTurn.Text = "Next Turn";
            btn_NextTurn.UseVisualStyleBackColor = false;
            btn_NextTurn.Click += btn_NextTurn_Click;
            // 
            // btn_UpdatePokemon
            // 
            btn_UpdatePokemon.BackColor = Color.GreenYellow;
            btn_UpdatePokemon.Location = new Point(153, 90);
            btn_UpdatePokemon.Name = "btn_UpdatePokemon";
            btn_UpdatePokemon.Size = new Size(140, 29);
            btn_UpdatePokemon.TabIndex = 14;
            btn_UpdatePokemon.Text = "Update Pokémon";
            btn_UpdatePokemon.UseVisualStyleBackColor = false;
            btn_UpdatePokemon.Click += btn_UpdatePokemon_Click;
            // 
            // btn_Reset
            // 
            btn_Reset.BackColor = SystemColors.ActiveCaptionText;
            btn_Reset.ForeColor = Color.FromArgb(192, 0, 0);
            btn_Reset.Location = new Point(15, 343);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(94, 29);
            btn_Reset.TabIndex = 15;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = false;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // lbl_Dex
            // 
            lbl_Dex.AutoSize = true;
            lbl_Dex.Location = new Point(178, 47);
            lbl_Dex.Name = "lbl_Dex";
            lbl_Dex.Size = new Size(38, 20);
            lbl_Dex.TabIndex = 16;
            lbl_Dex.Text = "Dex:";
            // 
            // txtbx_DexInput
            // 
            txtbx_DexInput.Location = new Point(222, 47);
            txtbx_DexInput.Name = "txtbx_DexInput";
            txtbx_DexInput.Size = new Size(37, 27);
            txtbx_DexInput.TabIndex = 17;
            // 
            // btn_MoveUp
            // 
            btn_MoveUp.BackColor = Color.LightGreen;
            btn_MoveUp.Location = new Point(390, 400);
            btn_MoveUp.Name = "btn_MoveUp";
            btn_MoveUp.Size = new Size(185, 29);
            btn_MoveUp.TabIndex = 18;
            btn_MoveUp.Text = "Move Up";
            btn_MoveUp.UseVisualStyleBackColor = false;
            btn_MoveUp.Click += btn_MoveUp_Click;
            // 
            // btn_MoveDown
            // 
            btn_MoveDown.BackColor = Color.Pink;
            btn_MoveDown.Location = new Point(699, 400);
            btn_MoveDown.Name = "btn_MoveDown";
            btn_MoveDown.Size = new Size(185, 29);
            btn_MoveDown.TabIndex = 19;
            btn_MoveDown.Text = "Move Down";
            btn_MoveDown.UseVisualStyleBackColor = false;
            btn_MoveDown.Click += btn_MoveDown_Click;
            // 
            // chkbx_TrickRoom
            // 
            chkbx_TrickRoom.AutoSize = true;
            chkbx_TrickRoom.CheckAlign = ContentAlignment.MiddleRight;
            chkbx_TrickRoom.Location = new Point(188, 348);
            chkbx_TrickRoom.Name = "chkbx_TrickRoom";
            chkbx_TrickRoom.Size = new Size(105, 24);
            chkbx_TrickRoom.TabIndex = 21;
            chkbx_TrickRoom.Text = "Trick Room";
            chkbx_TrickRoom.UseVisualStyleBackColor = true;
            chkbx_TrickRoom.CheckedChanged += CheckTrickRoomChanged;
            // 
            // dgv_Tracker
            // 
            dgv_Tracker.AllowUserToAddRows = false;
            dgv_Tracker.BackgroundColor = SystemColors.ControlLightLight;
            dgv_Tracker.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Tracker.Columns.AddRange(new DataGridViewColumn[] { dgch_Pokemon, dgch_Initiative, dgch_SuccessesNeeded, dgch_Dexterity, dvch_Evaded, dvch_Clashed });
            dgv_Tracker.Location = new Point(299, 3);
            dgv_Tracker.Name = "dgv_Tracker";
            dgv_Tracker.RowHeadersWidth = 51;
            dgv_Tracker.Size = new Size(721, 391);
            dgv_Tracker.TabIndex = 22;
            dgv_Tracker.CellMouseClick += dgv_Tracker_CellMouseClick;
            // 
            // dgch_Pokemon
            // 
            dgch_Pokemon.HeaderText = "Pokémon";
            dgch_Pokemon.MinimumWidth = 6;
            dgch_Pokemon.Name = "dgch_Pokemon";
            dgch_Pokemon.ReadOnly = true;
            dgch_Pokemon.Width = 120;
            // 
            // dgch_Initiative
            // 
            dgch_Initiative.HeaderText = "Initiative";
            dgch_Initiative.MinimumWidth = 6;
            dgch_Initiative.Name = "dgch_Initiative";
            dgch_Initiative.ReadOnly = true;
            dgch_Initiative.Width = 70;
            // 
            // dgch_SuccessesNeeded
            // 
            dgch_SuccessesNeeded.HeaderText = "SN";
            dgch_SuccessesNeeded.MinimumWidth = 6;
            dgch_SuccessesNeeded.Name = "dgch_SuccessesNeeded";
            dgch_SuccessesNeeded.ReadOnly = true;
            dgch_SuccessesNeeded.Width = 40;
            // 
            // dgch_Dexterity
            // 
            dgch_Dexterity.HeaderText = "Dex";
            dgch_Dexterity.MinimumWidth = 6;
            dgch_Dexterity.Name = "dgch_Dexterity";
            dgch_Dexterity.ReadOnly = true;
            dgch_Dexterity.Width = 40;
            // 
            // dvch_Evaded
            // 
            dvch_Evaded.HeaderText = "Evaded?";
            dvch_Evaded.MinimumWidth = 6;
            dvch_Evaded.Name = "dvch_Evaded";
            dvch_Evaded.Width = 125;
            // 
            // dvch_Clashed
            // 
            dvch_Clashed.HeaderText = "Clashed?";
            dvch_Clashed.MinimumWidth = 6;
            dvch_Clashed.Name = "dvch_Clashed";
            dvch_Clashed.Width = 125;
            // 
            // btn_Clash
            // 
            btn_Clash.BackColor = Color.OrangeRed;
            btn_Clash.Location = new Point(12, 257);
            btn_Clash.Name = "btn_Clash";
            btn_Clash.Size = new Size(204, 37);
            btn_Clash.TabIndex = 23;
            btn_Clash.Text = "Clash";
            btn_Clash.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Clash.UseVisualStyleBackColor = false;
            // 
            // btn_Evade
            // 
            btn_Evade.BackColor = Color.LightSeaGreen;
            btn_Evade.Location = new Point(13, 300);
            btn_Evade.Name = "btn_Evade";
            btn_Evade.Size = new Size(203, 37);
            btn_Evade.TabIndex = 24;
            btn_Evade.Text = "Evade";
            btn_Evade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Evade.UseVisualStyleBackColor = false;
            // 
            // btn_MoveUndo
            // 
            btn_MoveUndo.BackColor = SystemColors.AppWorkspace;
            btn_MoveUndo.Location = new Point(234, 218);
            btn_MoveUndo.Name = "btn_MoveUndo";
            btn_MoveUndo.Size = new Size(36, 29);
            btn_MoveUndo.TabIndex = 25;
            btn_MoveUndo.Text = "↶";
            btn_MoveUndo.UseVisualStyleBackColor = false;
            // 
            // btn_ClashUndo
            // 
            btn_ClashUndo.BackColor = SystemColors.AppWorkspace;
            btn_ClashUndo.Location = new Point(234, 261);
            btn_ClashUndo.Name = "btn_ClashUndo";
            btn_ClashUndo.Size = new Size(36, 29);
            btn_ClashUndo.TabIndex = 26;
            btn_ClashUndo.Text = "↶";
            btn_ClashUndo.UseVisualStyleBackColor = false;
            // 
            // btn_EvadeUndo
            // 
            btn_EvadeUndo.BackColor = SystemColors.AppWorkspace;
            btn_EvadeUndo.Location = new Point(234, 304);
            btn_EvadeUndo.Name = "btn_EvadeUndo";
            btn_EvadeUndo.Size = new Size(36, 29);
            btn_EvadeUndo.TabIndex = 27;
            btn_EvadeUndo.Text = "↶";
            btn_EvadeUndo.UseVisualStyleBackColor = false;
            // 
            // FrontEnd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 636);
            Controls.Add(btn_EvadeUndo);
            Controls.Add(btn_ClashUndo);
            Controls.Add(btn_MoveUndo);
            Controls.Add(btn_Evade);
            Controls.Add(btn_Clash);
            Controls.Add(dgv_Tracker);
            Controls.Add(chkbx_TrickRoom);
            Controls.Add(btn_MoveDown);
            Controls.Add(btn_MoveUp);
            Controls.Add(txtbx_DexInput);
            Controls.Add(lbl_Dex);
            Controls.Add(btn_Reset);
            Controls.Add(btn_UpdatePokemon);
            Controls.Add(btn_NextTurn);
            Controls.Add(lbl_RoundCount);
            Controls.Add(lbl_Round);
            Controls.Add(panelTurn);
            Controls.Add(btn_AddPokemon);
            Controls.Add(btn_Faint);
            Controls.Add(btn_UseMove);
            Controls.Add(btn_NewRound);
            Controls.Add(txtbx_InitiativeInput);
            Controls.Add(lbl_Initiative);
            Controls.Add(txtbx_Pokéinput);
            Controls.Add(lbl_Pokémon);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrontEnd";
            Text = "PokeRole Initiative Tracker";
            panelTurn.ResumeLayout(false);
            panelTurn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Tracker).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Pokémon;
        private TextBox txtbx_Pokéinput;
        private Label lbl_Initiative;
        private TextBox txtbx_InitiativeInput;
        private Button btn_NewRound;
        private Button btn_UseMove;
        private Button btn_Faint;
        private Button btn_AddPokemon;
        private Panel panelTurn;
        private Label lbl_Turn;
        private Label lbl_Round;
        private Label lbl_RoundCount;
        private Button btn_NextTurn;
        private Button btn_UpdatePokemon;
        private Button btn_Reset;
        private Label lbl_Dex;
        private TextBox txtbx_DexInput;
        private Button btn_MoveUp;
        private Button btn_MoveDown;
        private Button btn_Help;
        private CheckBox chkbx_TrickRoom;
        private DataGridView dgv_Tracker;
        private Button btn_Bulbapedia;
        private Button btn_pdb;
        private Button btn_Clash;
        private Button btn_Evade;
        private DataGridViewTextBoxColumn dgch_Pokemon;
        private DataGridViewTextBoxColumn dgch_Initiative;
        private DataGridViewTextBoxColumn dgch_SuccessesNeeded;
        private DataGridViewTextBoxColumn dgch_Dexterity;
        private DataGridViewTextBoxColumn dvch_Evaded;
        private DataGridViewTextBoxColumn dvch_Clashed;
        private Button btn_MoveUndo;
        private Button btn_ClashUndo;
        private Button btn_EvadeUndo;
    }
}
