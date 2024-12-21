﻿namespace InitiativeTracker
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
            btn_NewRound = new Button();
            btn_UseAction = new Button();
            button1 = new Button();
            btn_AddPokemon = new Button();
            panelTurn = new Panel();
            lbl_Turn = new Label();
            lstvw_InitTracker = new ListView();
            ch_Pokemon = new ColumnHeader();
            ch_Initiative = new ColumnHeader();
            ch_Successes = new ColumnHeader();
            lbl_Round = new Label();
            lbl_RoundCount = new Label();
            btn_NextTurn = new Button();
            btn_UpdatePokemon = new Button();
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
            txtbx_Pokéinput.Size = new Size(171, 27);
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
            txtbx_InitiativeInput.Location = new Point(160, 44);
            txtbx_InitiativeInput.Name = "txtbx_InitiativeInput";
            txtbx_InitiativeInput.Size = new Size(35, 27);
            txtbx_InitiativeInput.TabIndex = 3;
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
            btn_NewRound.Click += btn_NewRound_Click;
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
            btn_UseAction.Click += btn_UseAction_Click;
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
            // btn_AddPokemon
            // 
            btn_AddPokemon.BackColor = Color.LawnGreen;
            btn_AddPokemon.Location = new Point(119, 89);
            btn_AddPokemon.Name = "btn_AddPokemon";
            btn_AddPokemon.Size = new Size(140, 29);
            btn_AddPokemon.TabIndex = 8;
            btn_AddPokemon.Text = "Add Pokémon";
            btn_AddPokemon.UseVisualStyleBackColor = false;
            btn_AddPokemon.Click += btn_AddPokemon_Click;
            // 
            // panelTurn
            // 
            panelTurn.BackColor = SystemColors.ActiveCaption;
            panelTurn.Controls.Add(lbl_Turn);
            panelTurn.Location = new Point(12, 289);
            panelTurn.Name = "panelTurn";
            panelTurn.Size = new Size(500, 199);
            panelTurn.TabIndex = 9;
            // 
            // lbl_Turn
            // 
            lbl_Turn.AutoSize = true;
            lbl_Turn.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Turn.Location = new Point(129, 94);
            lbl_Turn.Name = "lbl_Turn";
            lbl_Turn.Size = new Size(217, 29);
            lbl_Turn.TabIndex = 0;
            lbl_Turn.Text = "Who's Turn Is It?";
            // 
            // lstvw_InitTracker
            // 
            lstvw_InitTracker.Columns.AddRange(new ColumnHeader[] { ch_Pokemon, ch_Initiative, ch_Successes });
            lstvw_InitTracker.Location = new Point(265, 6);
            lstvw_InitTracker.Name = "lstvw_InitTracker";
            lstvw_InitTracker.Size = new Size(245, 254);
            lstvw_InitTracker.TabIndex = 10;
            lstvw_InitTracker.UseCompatibleStateImageBehavior = false;
            lstvw_InitTracker.View = View.Details;
            // 
            // ch_Pokemon
            // 
            ch_Pokemon.Text = "Pokémon";
            ch_Pokemon.Width = 120;
            // 
            // ch_Initiative
            // 
            ch_Initiative.Text = "I";
            // 
            // ch_Successes
            // 
            ch_Successes.Text = "SN";
            // 
            // lbl_Round
            // 
            lbl_Round.AutoSize = true;
            lbl_Round.Location = new Point(30, 238);
            lbl_Round.Name = "lbl_Round";
            lbl_Round.Size = new Size(55, 20);
            lbl_Round.TabIndex = 11;
            lbl_Round.Text = "Round:";
            // 
            // lbl_RoundCount
            // 
            lbl_RoundCount.AutoSize = true;
            lbl_RoundCount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_RoundCount.Location = new Point(91, 229);
            lbl_RoundCount.Name = "lbl_RoundCount";
            lbl_RoundCount.Size = new Size(26, 31);
            lbl_RoundCount.TabIndex = 12;
            lbl_RoundCount.Text = "0";
            // 
            // btn_NextTurn
            // 
            btn_NextTurn.BackColor = Color.PapayaWhip;
            btn_NextTurn.Location = new Point(119, 181);
            btn_NextTurn.Name = "btn_NextTurn";
            btn_NextTurn.Size = new Size(140, 29);
            btn_NextTurn.TabIndex = 13;
            btn_NextTurn.Text = "Next Turn";
            btn_NextTurn.UseVisualStyleBackColor = false;
            // 
            // btn_UpdatePokemon
            // 
            btn_UpdatePokemon.BackColor = Color.GreenYellow;
            btn_UpdatePokemon.Location = new Point(119, 135);
            btn_UpdatePokemon.Name = "btn_UpdatePokemon";
            btn_UpdatePokemon.Size = new Size(140, 29);
            btn_UpdatePokemon.TabIndex = 14;
            btn_UpdatePokemon.Text = "Update Pokémon";
            btn_UpdatePokemon.UseVisualStyleBackColor = false;
            btn_UpdatePokemon.Click += btn_UpdatePokemon_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 500);
            Controls.Add(btn_UpdatePokemon);
            Controls.Add(btn_NextTurn);
            Controls.Add(lbl_RoundCount);
            Controls.Add(lbl_Round);
            Controls.Add(lstvw_InitTracker);
            Controls.Add(panelTurn);
            Controls.Add(btn_AddPokemon);
            Controls.Add(button1);
            Controls.Add(btn_UseAction);
            Controls.Add(btn_NewRound);
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
        private Button btn_NewRound;
        private Button btn_UseAction;
        private Button button1;
        private Button btn_AddPokemon;
        private Panel panelTurn;
        private Label lbl_Turn;
        private ListView lstvw_InitTracker;
        private ColumnHeader ch_Pokemon;
        private ColumnHeader ch_Initiative;
        private ColumnHeader ch_Successes;
        private Label lbl_Round;
        private Label lbl_RoundCount;
        private Button btn_NextTurn;
        private Button btn_UpdatePokemon;
    }
}
