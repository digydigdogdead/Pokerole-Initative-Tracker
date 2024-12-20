namespace InitiativeTracker
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
            lbl_Pokémon = new Label();
            txtbx_Pokéinput = new TextBox();
            lbl_Initiative = new Label();
            txtbx_InitiativeInput = new TextBox();
            lstbx_InitiativeTracker = new ListBox();
            btn_NewRound = new Button();
            btn_UseAction = new Button();
            button1 = new Button();
            button2 = new Button();
            panelTurn = new Panel();
            lbl_Turn = new Label();
            panelTurn.SuspendLayout();
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
            txtbx_Pokéinput.Size = new Size(144, 27);
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
            txtbx_InitiativeInput.Location = new Point(141, 44);
            txtbx_InitiativeInput.Name = "txtbx_InitiativeInput";
            txtbx_InitiativeInput.Size = new Size(35, 27);
            txtbx_InitiativeInput.TabIndex = 3;
            // 
            // lstbx_InitiativeTracker
            // 
            lstbx_InitiativeTracker.FormattingEnabled = true;
            lstbx_InitiativeTracker.Location = new Point(253, 6);
            lstbx_InitiativeTracker.Name = "lstbx_InitiativeTracker";
            lstbx_InitiativeTracker.Size = new Size(251, 204);
            lstbx_InitiativeTracker.TabIndex = 4;
            // 
            // btn_NewRound
            // 
            btn_NewRound.BackColor = Color.Gold;
            btn_NewRound.Location = new Point(12, 135);
            btn_NewRound.Name = "btn_NewRound";
            btn_NewRound.Size = new Size(94, 29);
            btn_NewRound.TabIndex = 5;
            btn_NewRound.Text = "New Round";
            btn_NewRound.UseVisualStyleBackColor = false;
            // 
            // btn_UseAction
            // 
            btn_UseAction.BackColor = Color.Peru;
            btn_UseAction.Location = new Point(12, 89);
            btn_UseAction.Name = "btn_UseAction";
            btn_UseAction.Size = new Size(94, 29);
            btn_UseAction.TabIndex = 6;
            btn_UseAction.Text = "Use Action";
            btn_UseAction.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(13, 181);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Faint";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LawnGreen;
            button2.Location = new Point(119, 181);
            button2.Name = "button2";
            button2.Size = new Size(113, 29);
            button2.TabIndex = 8;
            button2.Text = "Add Pokémon";
            button2.UseVisualStyleBackColor = false;
            // 
            // panelTurn
            // 
            panelTurn.BackColor = SystemColors.ActiveCaption;
            panelTurn.Controls.Add(lbl_Turn);
            panelTurn.Location = new Point(13, 239);
            panelTurn.Name = "panelTurn";
            panelTurn.Size = new Size(491, 199);
            panelTurn.TabIndex = 9;
            // 
            // lbl_Turn
            // 
            lbl_Turn.AutoSize = true;
            lbl_Turn.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Turn.Location = new Point(128, 89);
            lbl_Turn.Name = "lbl_Turn";
            lbl_Turn.Size = new Size(217, 29);
            lbl_Turn.TabIndex = 0;
            lbl_Turn.Text = "Who's Turn Is It?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 450);
            Controls.Add(panelTurn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_UseAction);
            Controls.Add(btn_NewRound);
            Controls.Add(lstbx_InitiativeTracker);
            Controls.Add(txtbx_InitiativeInput);
            Controls.Add(lbl_Initiative);
            Controls.Add(txtbx_Pokéinput);
            Controls.Add(lbl_Pokémon);
            Name = "Form1";
            Text = "Pokemon Initiative Tracker";
            panelTurn.ResumeLayout(false);
            panelTurn.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Pokémon;
        private TextBox txtbx_Pokéinput;
        private Label lbl_Initiative;
        private TextBox txtbx_InitiativeInput;
        private ListBox lstbx_InitiativeTracker;
        private Button btn_NewRound;
        private Button btn_UseAction;
        private Button button1;
        private Button button2;
        private Panel panelTurn;
        private Label lbl_Turn;
    }
}
