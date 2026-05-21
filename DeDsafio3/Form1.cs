namespace DeDsafio3
{
    public partial class Form1 : Form
    {
        CGrafo grafoUDB = new CGrafo();
        public Form1()
        {
            InitializeComponent();
        }

        public void CargarNodos()
        {
            String[] lineas = System.IO.File.ReadAllLines("nodos.csv");

            for (int i = 1; i < lineas.Length; i++)
            {
                String[] datos = lineas[i].Split(',');
                string nombreEdificio = datos[0].Trim();
                int posX = int.Parse(datos[1].Trim());
                int posY = int.Parse(datos[2].Trim());

                grafoUDB.AgregarVertice(nombreEdificio, posX, posY);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Evita errores si el grafo aún está vacío
            if (grafoUDB.PrimerVertice == null) return;

            Graphics g = e.Graphics;
            SolidBrush brochaNodo = new SolidBrush(Color.Blue);
            Font fuenteTexto = new Font("Arial", 10);
            SolidBrush brochaTexto = new SolidBrush(Color.Black);

            CVertice actual = grafoUDB.PrimerVertice;
            while (actual != null)
            {
                // Dibuja un círculo de 15x15 píxeles en la posición del nodo
                g.FillEllipse(brochaNodo, actual.x, actual.y, 15, 15);
                g.DrawString(actual.Nombre,fuenteTexto, brochaTexto,  actual.x, actual.y- 15);

                actual = actual.Siguiente;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CargarNodos();
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"X: {e.X}, Y: {e.Y}");
        }
    }
}
