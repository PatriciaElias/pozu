namespace pozuelo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUser_Click(object sender, EventArgs e)
        {
           //selecciona todo el texto
              txtUser.SelectAll();

        }
        private void txtPassword_Click(object sender, EventArgs e)
        {
            //selecciona todo el texto
            txtPassword.SelectAll();

        }
    

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (txtUser.Text == "")
                {
                    return;
                }

                txtUser.ForeColor = Color.Black; //cambio de color del texto
                

            }
            catch { }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == "")
                {
                    txtPassword.Text.ToString();
                    return;
                }
                
                txtPassword.ForeColor = Color.Black; //cambio de color del texto
                txtPassword.PasswordChar = '*'; //encriptacion de la contraseña

            }
            catch { }

        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
           // if (txtUser.Text == "" && txtPassword.Text == ""){
                new Menu().Show();//muestra el nuevo formulario
               // this.Hide();}

            /*else {
                //alerta si el usuario y contraseña estan mal ingresados
                MessageBox.Show("El usuario o contraseña ingresados son incorrectos, ingresar de nuevo.");
                txtUser.Clear();
                txtPassword.Clear();
                txtUser.Focus();}*/
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //ventana de aviso
            DialogResult result = MessageBox.Show("¿Esta seguro de Cerrar el programa?", "¡Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //accion de movimiento de ventanas
        bool vai = false;
        private void pnlEncabezado_MouseDown(object sender, MouseEventArgs e)
        {
            vai = true;
        }

        private void pnlEncabezado_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (vai == true)
            {
                Point cursorLocation = Cursor.Position;
                this.Location = new Point(cursorLocation.X - 20, 
                    cursorLocation.Y - 20);
            }*/
        }

        //cambia de color el texto del boton
        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = SystemColors.Control;
        }
    }
}