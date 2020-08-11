using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropCalc
{
    public partial class PropCalc : Form
    {
        private mathMagic magic;
        private DataGridView table = new DataGridView();
        private Button secondStepBtn;
        private Button secondStepCalcBtn;
        private Label traction;
        private Label R;
        private Label efficiency;
        private Label alfaLabel = new Label();
        private Label realativeBLabel = new Label();
        private Label fixRLabel = new Label();
        private Label fixPLabel = new Label();
        private int angle;
        private float b;

        private MaskedTextBox alfa = new MaskedTextBox();
        private MaskedTextBox realativeB = new MaskedTextBox();
        private MaskedTextBox fixR = new MaskedTextBox();
        private MaskedTextBox fixN = new MaskedTextBox();
        public PropCalc()
        {
            InitializeComponent();
        }

        private void firstStepBtn_Click(object sender, EventArgs e)
        {
            int powerVal;
            int freqVal;
            float maxRVal;
            int speed;
            int maxRoundS;
            float densityVal;
            float desiredEff;
            float effStepVal;
            int bladesVal;
            bool parsed = true;

            if (!int.TryParse(power.Text, out powerVal))
            {
                MessageBox.Show("Мощность не введена");
                parsed = false;
            }

            if (!int.TryParse(freq.Text, out freqVal))
            {
                MessageBox.Show("Частота не введена");
                parsed = false;
            }

            if (!float.TryParse(maxR.Text, out maxRVal))
            {
                MessageBox.Show("Максимально возможный радиус винта не введён");
                parsed = false;
            }

            if (!int.TryParse(velocity.Text, out speed))
            {
                MessageBox.Show("Скорость винта не введена");
                parsed = false;
            }

            if (!int.TryParse(maxRoundV.Text, out maxRoundS))
            {
                MessageBox.Show("Максимальная скорость кончика не введена");
                parsed = false;
            }

            if (!float.TryParse(density.Text, out densityVal))
            {
                MessageBox.Show("Плотность не введена");
                parsed = false;
            }

            if (!float.TryParse(desEff.Text, out desiredEff))
            {
                MessageBox.Show("Желаемый КПД не введён");
                parsed = false;
            }

            if (!float.TryParse(effStep.Text, out effStepVal))
            {
                MessageBox.Show("Шаг КПД не введён");
                parsed = false;
            }

            if (!int.TryParse(blades.Text, out bladesVal))
            {
                MessageBox.Show("Шаг КПД не введён");
                parsed = false;
            }


            if (parsed)
            {
                magic = new mathMagic(powerVal, freqVal, maxRVal, speed, maxRoundS, densityVal, desiredEff, effStepVal, bladesVal);

                magic.firstStep();

                MessageBox.Show("Тяга: " + magic.Traction + "\n Радиус: " + magic.Radius + "\n КПД: " + magic.Eff);

                if (secondStepBtn == null)
                {



                    firstStepBtn.Location = new Point(300, 380);



                    secondStepBtn = new Button();

                    secondStepBtn.BackColor = Color.White;
                    secondStepBtn.ForeColor = Color.Black;
                    secondStepBtn.Text = "Этап 2";
                    secondStepBtn.Location = new Point(380, 380);
                    secondStepBtn.Click += secondStepBtn_Click;

                    this.Controls.Add(secondStepBtn);


                    traction = new Label();
                    traction.Text = "Предполагаемая тяга: " + magic.Traction + " Н";
                    traction.Location = new Point(500, 30);
                    traction.Width = 200;
                    this.Controls.Add(traction);

                    R = new Label();
                    R.Text = "Предполагаемый радиус: " + magic.Radius + " м";
                    R.Location = new Point(500, 60);
                    R.Width = 200;
                    this.Controls.Add(R);

                    efficiency = new Label();
                    efficiency.Text = "Предполагаемый КПД: " + magic.Eff;
                    efficiency.Location = new Point(500, 90);
                    efficiency.Width = 200;
                    this.Controls.Add(efficiency);


                } else
                {
                    traction.Text = "Предполагаемая тяга: " + magic.Traction + "Н";
                    R.Text = "Предполагаемый радиус: " + magic.Radius + "м";
                    efficiency.Text = "Предполагаемый КПД: " + magic.Eff;

                }

            }


        }

        private void secondStepBtn_Click(object sender, EventArgs e)
        {

            this.Controls.Remove(firstStepBtn);
            this.Controls.Remove(secondStepBtn);
            this.Controls.Remove(effStep);
            this.Controls.Remove(blades);
            this.Controls.Remove(effStepLabel);
            this.Controls.Remove(bladesLabel);
            this.Controls.Remove(power);
            this.Controls.Remove(freq);
            this.Controls.Remove(maxR);
            this.Controls.Remove(velocity);
            this.Controls.Remove(density);
            this.Controls.Remove(maxRoundV);
            this.Controls.Remove(desEff);


            this.Controls.Remove(powerLabel);
            this.Controls.Remove(freqLabel);
            this.Controls.Remove(radiusLabel);
            this.Controls.Remove(V0Label);
            this.Controls.Remove(tipVLabel);
            this.Controls.Remove(densityLabel);
            this.Controls.Remove(effLabel);


            alfa.Location = new Point(30, 30);
            alfa.PromptChar = ' ';
            alfa.HidePromptOnLeave = true;
            alfa.Mask = "00";
            alfa.Text = "4";

            alfaLabel.Location = new Point(150, 35);
            alfaLabel.Text = "Угол атаки в градусах";
            alfaLabel.Width = 200;


            realativeB.Location = new Point(30, 60);
            realativeB.PromptChar = ' ';
            realativeB.HidePromptOnLeave = true;
            realativeB.Mask = "0.0000";
            realativeB.Text = "0.08";

            realativeBLabel.Location = new Point(150, 65);
            realativeBLabel.Text = "Относительная ширина";
            realativeBLabel.Width = 200;



            this.Controls.Add(alfa);
            this.Controls.Add(alfaLabel);
            this.Controls.Add(realativeB);
            this.Controls.Add(realativeBLabel);



            secondStepCalcBtn = new Button();

            secondStepCalcBtn.BackColor = Color.White;
            secondStepCalcBtn.ForeColor = Color.Black;
            secondStepCalcBtn.Text = "Рассчёт 2 этап";
            secondStepCalcBtn.Location = new Point(380, 380);
            secondStepCalcBtn.Click += secondStepCalcBtn_Click;

            this.Controls.Add(secondStepCalcBtn);

        }




        private void secondStepCalcBtn_Click(Object sender, EventArgs e)
        {


            if (secondStepCalcBtn.Text == "Пересчитать")
            {
                
                angle = int.Parse(alfa.Text);
                b = float.Parse(realativeB.Text);

                magic.power = int.Parse(fixN.Text);
                magic.Radius = float.Parse(fixR.Text);
                magic.PowerSum = 0;
                magic.TractionSum = 0;
                table.Rows.Clear();

                List<PropPart> parts = magic.secondStep(angle, b);

     

                

                populateTable(parts);
                recalcSetUp();
            }
            else
            {

                angle = int.Parse(alfa.Text);
                b = float.Parse(realativeB.Text);




                List<PropPart> parts = magic.secondStep(angle, b);

                cleanUp();

                setUpView();

                populateTable(parts);

                recalcSetUp();
            }







        }


        private void cleanUp()
        {


          
            this.Controls.Remove(power);
            this.Controls.Remove(freq);
            this.Controls.Remove(maxR);
            this.Controls.Remove(velocity);
            this.Controls.Remove(maxRoundV);
            this.Controls.Remove(density);
            this.Controls.Remove(desEff);
            this.Controls.Remove(effStep);
            this.Controls.Remove(blades);


            this.Controls.Remove(powerLabel);
            this.Controls.Remove(freqLabel);
            this.Controls.Remove(radiusLabel);
            this.Controls.Remove(V0Label);
            this.Controls.Remove(tipVLabel);
            this.Controls.Remove(densityLabel);
            this.Controls.Remove(effLabel);
            this.Controls.Remove(effStepLabel);
            this.Controls.Remove(bladesLabel);

            this.Controls.Remove(traction);
            this.Controls.Remove(R);
            this.Controls.Remove(efficiency);

    

            this.Controls.Remove(alfa);
            this.Controls.Remove(realativeB);
            this.Controls.Remove(alfaLabel);
            this.Controls.Remove(realativeBLabel);
        }

        private void setUpView()
        {

            this.Controls.Add(table);

            table.ColumnCount = 11;

            table.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            table.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            table.ColumnHeadersDefaultCellStyle.Font = new Font(table.Font, FontStyle.Bold);
            table.DefaultCellStyle.Font = new Font("Arial", 12);
            this.Size = new Size(1200, 500);

            table.Name = "Результаты второго этапа";
            table.Location = new Point(0, 0);
            table.Size = new Size(1200, 200);
            table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            table.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            table.GridColor = Color.Black;
            table.RowHeadersVisible = false;
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.ReadOnly = true;



            table.Columns[0].Name = "Параметр";
            table.Columns[1].Name = "0.35";
            table.Columns[2].Name = "0.45";
            table.Columns[3].Name = "0.55";
            table.Columns[4].Name = "0.65";
            table.Columns[5].Name = "0.75";
            table.Columns[6].Name = "0.85";
            table.Columns[7].Name = "0.95";
            table.Columns[8].Name = "Сумма";
            table.Columns[9].Name = "Предполагаемые";
            table.Columns[10].Name = "Отличие";


            





        }

        private void populateTable(List<PropPart> parts)
        {

            String[] RadiusRow =
            {
                "Радиус",
                parts[0].R.ToString(),
                parts[1].R.ToString(),
                parts[2].R.ToString(),
                parts[3].R.ToString(),
                parts[4].R.ToString(),
                parts[5].R.ToString(),
                parts[6].R.ToString(),
          
            };

            String[] thicknessRow =
            {
                "ĉ",
                parts[0].thickness.ToString(),
                parts[1].thickness.ToString(),
                parts[2].thickness.ToString(),
                parts[3].thickness.ToString(),
                parts[4].thickness.ToString(),
                parts[5].thickness.ToString(),
                parts[6].thickness.ToString(),
           
            };

            String[] chordRow =
{
                "b",
                parts[0].chord.ToString(),
                parts[1].chord.ToString(),
                parts[2].chord.ToString(),
                parts[3].chord.ToString(),
                parts[4].chord.ToString(),
                parts[5].chord.ToString(),
                parts[6].chord.ToString(),
             
            };

            String[] anglePhRow =
{
                "φ",
                parts[0].anglePh.ToString(),
                parts[1].anglePh.ToString(),
                parts[2].anglePh.ToString(),
                parts[3].anglePh.ToString(),
                parts[4].anglePh.ToString(),
                parts[5].anglePh.ToString(),
                parts[6].anglePh.ToString(),
              
            };

            String[] deltaTractionRow =
{
                "ΔP",
                parts[0].deltaTraction.ToString(),
                parts[1].deltaTraction.ToString(),
                parts[2].deltaTraction.ToString(),
                parts[3].deltaTraction.ToString(),
                parts[4].deltaTraction.ToString(),
                parts[5].deltaTraction.ToString(),
                parts[6].deltaTraction.ToString(),
              
            };

            String[] deltaPowerRow =
{
                "ΔN",
                parts[0].deltaPower.ToString(),
                parts[1].deltaPower.ToString(),
                parts[2].deltaPower.ToString(),
                parts[3].deltaPower.ToString(),
                parts[4].deltaPower.ToString(),
                parts[5].deltaPower.ToString(),
                parts[6].deltaPower.ToString(),
                
                
            };

            float P = magic.Traction * 0.96F;
            float N = magic.power * 0.96F;

            float percentP = (float)Math.Round(Math.Abs(1 - (P / magic.TractionSum)), 2, MidpointRounding.AwayFromZero) * 100;
            float percentN = (float)Math.Round(Math.Abs(1 - (N / magic.PowerSum)), 2, MidpointRounding.AwayFromZero) * 100;

            String[] tractionRow =
            {
                "P",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                magic.TractionSum.ToString(),
                P.ToString(),
                percentP + "%"
                
            };

            String[] powerRow =
{
                "N",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                magic.PowerSum.ToString(),
                N.ToString(),
                percentN + "%"
                
            };




            table.Rows.Add(RadiusRow);
            table.Rows.Add(thicknessRow);
            table.Rows.Add(chordRow);
            table.Rows.Add(anglePhRow);
            table.Rows.Add(deltaTractionRow);
            table.Rows.Add(deltaPowerRow);
            table.Rows.Add(tractionRow);
            table.Rows.Add(powerRow);






        }


        private void recalcSetUp()
        {
            alfa.Location = new Point(30, 300);
            alfa.Text = angle.ToString();
            alfaLabel.Location = new Point(150, 305);

            realativeB.Location = new Point(30, 330);


            realativeBLabel.Location = new Point(150, 335);
            realativeB.Text = b.ToString();



            fixR.Location = new Point(30, 360);
            fixR.PromptChar = ' ';
            fixR.HidePromptOnLeave = true;
            fixR.Mask = "0.00";
            fixR.Text = magic.Radius.ToString();

            fixRLabel.Location = new Point(150, 365);
            fixRLabel.Text = "Собственно радиус в метрах";
            fixRLabel.Width = 200;


            fixN.Location = new Point(30, 390);
            fixN.PromptChar = ' ';
            fixN.HidePromptOnLeave = true;
            fixN.Mask = "0000000000";
            fixN.Text = magic.power.ToString();

            fixPLabel.Location = new Point(150, 395);
            fixPLabel.Text = "Мощность в Ваттах";
            fixPLabel.Width = 200;

            secondStepCalcBtn.Location = new Point(500, 390);
            secondStepCalcBtn.Text = "Пересчитать";
            secondStepCalcBtn.Width = 90;


            

            


            this.Controls.Add(alfa);
            this.Controls.Add(alfaLabel);
            this.Controls.Add(realativeB);
            this.Controls.Add(realativeBLabel);

            this.Controls.Add(fixR);
            this.Controls.Add(fixN);

            this.Controls.Add(fixRLabel);
            this.Controls.Add(fixPLabel);
        }
    }
}
