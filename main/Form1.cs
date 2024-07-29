namespace ahorcado
{
    public partial class Form1 : Form
    {
        private string palabraSecreta;
        private string palabraOculta;
        private int intentosRestantes = 6;
        private int intentosPalabraCompleta = 3;
        private List<char> letraserroneas = new List<char>();
        public Form1()
        {
            InitializeComponent();
            palabraSecreta = ObtenerPalabraSecreta();
            palabraOculta = new string('_', palabraSecreta.Length);
            ActualizarInterfaz();
        }

        private string ObtenerPalabraSecreta()
        {
            // Aquí puedes tener una lista de palabras secretas y elegir una al azar
            //string[] palabras = { "computadora", "programacion", "desarrollador", "ahorcado", "openai" };
            //Random random = new Random();
            //return palabras[random.Next(palabras.Length)];
            //por DB
            Core.ORM.ORM oRM = new Core.ORM.ORM();
            return oRM.getPalabra();
        }

        private void ActualizarInterfaz()
        {
            PalabraLabel.Text = palabraOculta;
            IntentosLabel.Text = $"Intentos restantes: {intentosRestantes}";

            // Dibuja el ahorcado (ASCII art) según los intentos restantes
            string[] ahorcadoAscii =
            {
                 "  +---+",
                 "  |   |",
                $"  |   {(intentosRestantes < 6 ? "O" : " ")}",
                $"  |   {(intentosRestantes < 4 ? "/" : " ")}{(intentosRestantes < 5 ? "|" : " ")}{(intentosRestantes < 3 ? "\\" : " ")}",
                $"  |   {(intentosRestantes < 4 ? "/" : " ")} {(intentosRestantes < 2 ? "\\" : " ")}",
                 "  |",
                "======="
            };

            AhorcadoTextBox.Lines = ahorcadoAscii;
            letras_usadas.Text = string.Join(',', letraserroneas);
            if (intentosRestantes <= 0)
            {
                MessageBox.Show($"Perdiste. La palabra secreta era: {palabraSecreta}");
                ReiniciarJuego();
            }
        }

        private void ReiniciarJuego()
        {
            palabraSecreta = ObtenerPalabraSecreta();
            palabraOculta = new string('_', palabraSecreta.Length);
            intentosRestantes = 6;
            intentosPalabraCompleta = 3;
            letraserroneas = new List<char>();
            ActualizarInterfaz();
        }

        private void LetraTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                char letra = e.KeyChar;
                if (palabraSecreta.Contains(letra))
                {
                    for (int i = 0; i < palabraSecreta.Length; i++)
                    {
                        if (palabraSecreta[i] == letra)
                        {
                            palabraOculta = palabraOculta.Remove(i, 1).Insert(i, letra.ToString());
                        }
                    }
                }
                else
                {
                    if (letraserroneas.Contains(e.KeyChar))
                    {
                        MessageBox.Show("Letra repetida");
                    }
                    else
                    {
                        letraserroneas.Add(letra);
                        intentosRestantes--;
                    }

                }

                ActualizarInterfaz();

                if (palabraOculta == palabraSecreta)
                {
                    MessageBox.Show("¡Ganaste! Has adivinado la palabra.");
                    ReiniciarJuego();
                }

                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void IntentoPalabraButton_Click(object sender, EventArgs e)
        {
            string intento = IntentoPalabraTextBox.Text.ToLower();

            if (intento == palabraSecreta)
            {
                MessageBox.Show("¡Ganaste! Has adivinado la palabra.");
                ReiniciarJuego();
            }
            else
            {
                intentosPalabraCompleta--;

                if (intentosPalabraCompleta <= 0)
                {
                    MessageBox.Show($"Perdiste. La palabra secreta era: {palabraSecreta}");
                    ReiniciarJuego();
                }
                else
                {
                    MessageBox.Show($"Incorrecto. Te quedan {intentosPalabraCompleta} intentos para adivinar la palabra.");
                }
            }

            IntentoPalabraTextBox.Text = string.Empty;
        }
    }
}