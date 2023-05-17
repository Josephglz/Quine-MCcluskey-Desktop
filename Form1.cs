namespace MetodoTabularC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbNumVariables.SelectedIndex = 0;
        }

        private void btnSimplificar_Click(object sender, EventArgs e)
        {
            int numVariables = cbNumVariables.SelectedIndex + 2;
            QM q = new QM(numVariables);

            string tempMinTerms = txtMinterminos.Text;
            List<string> minTerms = tempMinTerms.Split(',').ToList();
            minTerms = minTerms.Select(x => q.Pad(q.DecToBin(Convert.ToInt32(x)))).ToList();

            minTerms.Sort();

            do
            {
                minTerms = q.Reduce(minTerms);
                minTerms.Sort();
            } while (!q.VectorsEqual(minTerms, q.Reduce(minTerms)));

            string ecuacion = "";
            for (int i = 0; i < minTerms.Count; i++)
            {
                ecuacion += q.GetValue(minTerms[i]);
                if(!(i == minTerms.Count - 1))
                {
                    ecuacion += " + ";
                }
            }
            //ecuacion += q.GetValue(minTerms[minTerms.Count - 1]);

            lblResultado.Text = ecuacion;
        }
    }
}