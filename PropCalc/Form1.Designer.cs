namespace PropCalc
{
    partial class PropCalc
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.firstStepBtn = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.MaskedTextBox();
            this.freq = new System.Windows.Forms.MaskedTextBox();
            this.maxR = new System.Windows.Forms.MaskedTextBox();
            this.density = new System.Windows.Forms.MaskedTextBox();
            this.maxRoundV = new System.Windows.Forms.MaskedTextBox();
            this.velocity = new System.Windows.Forms.MaskedTextBox();
            this.desEff = new System.Windows.Forms.MaskedTextBox();
            this.effStep = new System.Windows.Forms.MaskedTextBox();
            this.powerLabel = new System.Windows.Forms.Label();
            this.freqLabel = new System.Windows.Forms.Label();
            this.V0Label = new System.Windows.Forms.Label();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.effStepLabel = new System.Windows.Forms.Label();
            this.effLabel = new System.Windows.Forms.Label();
            this.densityLabel = new System.Windows.Forms.Label();
            this.tipVLabel = new System.Windows.Forms.Label();
            this.powerTip = new System.Windows.Forms.ToolTip(this.components);
            this.freqTip = new System.Windows.Forms.ToolTip(this.components);
            this.RadiusTip = new System.Windows.Forms.ToolTip(this.components);
            this.V0Tip = new System.Windows.Forms.ToolTip(this.components);
            this.tipVTip = new System.Windows.Forms.ToolTip(this.components);
            this.densityTip = new System.Windows.Forms.ToolTip(this.components);
            this.effTip = new System.Windows.Forms.ToolTip(this.components);
            this.effStepTip = new System.Windows.Forms.ToolTip(this.components);
            this.blades = new System.Windows.Forms.MaskedTextBox();
            this.bladesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstStepBtn
            // 
            this.firstStepBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstStepBtn.Location = new System.Drawing.Point(350, 380);
            this.firstStepBtn.Name = "firstStepBtn";
            this.firstStepBtn.Size = new System.Drawing.Size(75, 23);
            this.firstStepBtn.TabIndex = 0;
            this.firstStepBtn.Text = "Расчитать";
            this.firstStepBtn.UseVisualStyleBackColor = true;
            this.firstStepBtn.Click += new System.EventHandler(this.firstStepBtn_Click);
            // 
            // power
            // 
            this.power.HidePromptOnLeave = true;
            this.power.Location = new System.Drawing.Point(37, 22);
            this.power.Mask = "0000";
            this.power.Name = "power";
            this.power.PromptChar = ' ';
            this.power.ResetOnPrompt = false;
            this.power.Size = new System.Drawing.Size(100, 20);
            this.power.TabIndex = 1;
            this.powerTip.SetToolTip(this.power, "Лошадиные Силы");
            // 
            // freq
            // 
            this.freq.HidePromptOnLeave = true;
            this.freq.Location = new System.Drawing.Point(37, 48);
            this.freq.Mask = "0000000";
            this.freq.Name = "freq";
            this.freq.PromptChar = ' ';
            this.freq.Size = new System.Drawing.Size(100, 20);
            this.freq.TabIndex = 2;
            this.freqTip.SetToolTip(this.freq, "Обороты в минуту");
            this.freq.ValidatingType = typeof(int);
            // 
            // maxR
            // 
            this.maxR.HidePromptOnLeave = true;
            this.maxR.Location = new System.Drawing.Point(37, 74);
            this.maxR.Mask = "00.00";
            this.maxR.Name = "maxR";
            this.maxR.PromptChar = ' ';
            this.maxR.Size = new System.Drawing.Size(100, 20);
            this.maxR.TabIndex = 3;
            this.RadiusTip.SetToolTip(this.maxR, "в метрах");
            this.maxR.ValidatingType = typeof(int);
            // 
            // density
            // 
            this.density.HidePromptOnLeave = true;
            this.density.Location = new System.Drawing.Point(37, 152);
            this.density.Mask = "0.0000";
            this.density.Name = "density";
            this.density.PromptChar = ' ';
            this.density.Size = new System.Drawing.Size(100, 20);
            this.density.TabIndex = 6;
            this.densityTip.SetToolTip(this.density, "В зависимости от рассчётной высоты в килограммах на метр кубический");
            this.density.ValidatingType = typeof(int);
            // 
            // maxRoundV
            // 
            this.maxRoundV.HidePromptOnLeave = true;
            this.maxRoundV.Location = new System.Drawing.Point(37, 126);
            this.maxRoundV.Mask = "000";
            this.maxRoundV.Name = "maxRoundV";
            this.maxRoundV.PromptChar = ' ';
            this.maxRoundV.Size = new System.Drawing.Size(100, 20);
            this.maxRoundV.TabIndex = 5;
            this.tipVTip.SetToolTip(this.maxRoundV, "в метрах в секунду, макс 260 м/с");
            this.maxRoundV.ValidatingType = typeof(int);
            // 
            // velocity
            // 
            this.velocity.HidePromptOnLeave = true;
            this.velocity.Location = new System.Drawing.Point(37, 100);
            this.velocity.Mask = "000";
            this.velocity.Name = "velocity";
            this.velocity.PromptChar = ' ';
            this.velocity.Size = new System.Drawing.Size(100, 20);
            this.velocity.TabIndex = 4;
            this.V0Tip.SetToolTip(this.velocity, "т.е. расчётная скорость ЛА, в метрах в секунду");
            this.velocity.ValidatingType = typeof(int);
            // 
            // desEff
            // 
            this.desEff.HidePromptOnLeave = true;
            this.desEff.Location = new System.Drawing.Point(37, 178);
            this.desEff.Mask = "0.00";
            this.desEff.Name = "desEff";
            this.desEff.PromptChar = ' ';
            this.desEff.Size = new System.Drawing.Size(100, 20);
            this.desEff.TabIndex = 7;
            this.effTip.SetToolTip(this.desEff, "максимальынй КПД 0.75");
            this.desEff.ValidatingType = typeof(int);
            // 
            // effStep
            // 
            this.effStep.HidePromptOnLeave = true;
            this.effStep.Location = new System.Drawing.Point(37, 204);
            this.effStep.Mask = "0.00";
            this.effStep.Name = "effStep";
            this.effStep.PromptChar = ' ';
            this.effStep.Size = new System.Drawing.Size(100, 20);
            this.effStep.TabIndex = 8;
            this.effStep.TabStop = false;
            this.effStepTip.SetToolTip(this.effStep, "Алгоритм будет снижать КПД, если предоставленные параметры не могут обеспечить же" +
        "лаемый КПД, рекомендуется 0.05");
            this.effStep.ValidatingType = typeof(int);
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Location = new System.Drawing.Point(161, 25);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(197, 13);
            this.powerLabel.TabIndex = 9;
            this.powerLabel.Text = "Распологаемая мощность двигателя";
            this.powerTip.SetToolTip(this.powerLabel, "Лошадиные Силы");
            // 
            // freqLabel
            // 
            this.freqLabel.AutoSize = true;
            this.freqLabel.Location = new System.Drawing.Point(161, 51);
            this.freqLabel.Name = "freqLabel";
            this.freqLabel.Size = new System.Drawing.Size(135, 13);
            this.freqLabel.TabIndex = 10;
            this.freqLabel.Text = "Частота вращения винта";
            this.freqTip.SetToolTip(this.freqLabel, "Обороты в минуту");
            // 
            // V0Label
            // 
            this.V0Label.AutoSize = true;
            this.V0Label.Location = new System.Drawing.Point(161, 103);
            this.V0Label.Name = "V0Label";
            this.V0Label.Size = new System.Drawing.Size(142, 13);
            this.V0Label.TabIndex = 12;
            this.V0Label.Text = "Расчётная скорость винта";
            this.V0Tip.SetToolTip(this.V0Label, "т.е. расчётная скорость ЛА, в метрах в секунду");
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(161, 77);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(156, 13);
            this.radiusLabel.TabIndex = 11;
            this.radiusLabel.Text = "Максимальный радиус винта";
            this.RadiusTip.SetToolTip(this.radiusLabel, "в метрах");
            // 
            // effStepLabel
            // 
            this.effStepLabel.AutoSize = true;
            this.effStepLabel.Location = new System.Drawing.Point(161, 207);
            this.effStepLabel.Name = "effStepLabel";
            this.effStepLabel.Size = new System.Drawing.Size(107, 13);
            this.effStepLabel.TabIndex = 16;
            this.effStepLabel.Text = "Шаг снижения КПД";
            this.effStepTip.SetToolTip(this.effStepLabel, "Алгоритм будет снижать КПД, если предоставленные параметры не могут обеспечить же" +
        "лаемый КПД, , рекомендуется 0.05");
            // 
            // effLabel
            // 
            this.effLabel.AutoSize = true;
            this.effLabel.Location = new System.Drawing.Point(161, 181);
            this.effLabel.Name = "effLabel";
            this.effLabel.Size = new System.Drawing.Size(142, 13);
            this.effLabel.TabIndex = 15;
            this.effLabel.Text = "Исходный желаемый КПД";
            this.effTip.SetToolTip(this.effLabel, "максимальынй КПД 0.75");
            // 
            // densityLabel
            // 
            this.densityLabel.AutoSize = true;
            this.densityLabel.Location = new System.Drawing.Point(161, 155);
            this.densityLabel.Name = "densityLabel";
            this.densityLabel.Size = new System.Drawing.Size(104, 13);
            this.densityLabel.TabIndex = 14;
            this.densityLabel.Text = "Плотность воздуха";
            this.densityTip.SetToolTip(this.densityLabel, "В зависимости от рассчётной высоты в килограммах на метр кубический");
            // 
            // tipVLabel
            // 
            this.tipVLabel.AutoSize = true;
            this.tipVLabel.Location = new System.Drawing.Point(161, 129);
            this.tipVLabel.Name = "tipVLabel";
            this.tipVLabel.Size = new System.Drawing.Size(262, 13);
            this.tipVLabel.TabIndex = 13;
            this.tipVLabel.Text = "Максимально допустимая скрость конца лопасти";
            this.tipVTip.SetToolTip(this.tipVLabel, "в метрах в секунду, макс 260 м/с");
            // 
            // blades
            // 
            this.blades.HidePromptOnLeave = true;
            this.blades.Location = new System.Drawing.Point(37, 230);
            this.blades.Mask = "0";
            this.blades.Name = "blades";
            this.blades.PromptChar = ' ';
            this.blades.Size = new System.Drawing.Size(100, 20);
            this.blades.TabIndex = 17;
            this.blades.ValidatingType = typeof(int);
            // 
            // bladesLabel
            // 
            this.bladesLabel.AutoSize = true;
            this.bladesLabel.Location = new System.Drawing.Point(161, 233);
            this.bladesLabel.Name = "bladesLabel";
            this.bladesLabel.Size = new System.Drawing.Size(116, 13);
            this.bladesLabel.TabIndex = 18;
            this.bladesLabel.Text = "Количество лопастей";
            // 
            // PropCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.bladesLabel);
            this.Controls.Add(this.blades);
            this.Controls.Add(this.effStepLabel);
            this.Controls.Add(this.effLabel);
            this.Controls.Add(this.densityLabel);
            this.Controls.Add(this.tipVLabel);
            this.Controls.Add(this.V0Label);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.freqLabel);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.effStep);
            this.Controls.Add(this.desEff);
            this.Controls.Add(this.density);
            this.Controls.Add(this.maxRoundV);
            this.Controls.Add(this.velocity);
            this.Controls.Add(this.maxR);
            this.Controls.Add(this.freq);
            this.Controls.Add(this.power);
            this.Controls.Add(this.firstStepBtn);
            this.Name = "PropCalc";
            this.Text = "PropCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button firstStepBtn;
        private System.Windows.Forms.MaskedTextBox power;
        private System.Windows.Forms.MaskedTextBox freq;
        private System.Windows.Forms.MaskedTextBox maxR;
        private System.Windows.Forms.MaskedTextBox density;
        private System.Windows.Forms.MaskedTextBox maxRoundV;
        private System.Windows.Forms.MaskedTextBox velocity;
        private System.Windows.Forms.MaskedTextBox desEff;
        private System.Windows.Forms.MaskedTextBox effStep;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label freqLabel;
        private System.Windows.Forms.Label V0Label;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label effStepLabel;
        private System.Windows.Forms.Label effLabel;
        private System.Windows.Forms.Label densityLabel;
        private System.Windows.Forms.Label tipVLabel;
        private System.Windows.Forms.ToolTip powerTip;
        private System.Windows.Forms.ToolTip freqTip;
        private System.Windows.Forms.ToolTip V0Tip;
        private System.Windows.Forms.ToolTip RadiusTip;
        private System.Windows.Forms.ToolTip densityTip;
        private System.Windows.Forms.ToolTip tipVTip;
        private System.Windows.Forms.ToolTip effTip;
        private System.Windows.Forms.ToolTip effStepTip;
        private System.Windows.Forms.MaskedTextBox blades;
        private System.Windows.Forms.Label bladesLabel;
    }
}

