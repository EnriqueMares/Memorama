using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Memorama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Banderas
        static bool bandera1=false;
        static bool bandera2 = false;
        static bool bandera3 = false;        
        static bool bandera4 = false;
        static bool bandera5 = false;
        static bool bandera6 = false;
        static bool bandera7 = false;
        static bool bandera8 = false;
        static bool bandera9 = false;
        static bool bandera10 = false;
        static bool bandera11 = false;
        static bool bandera12 = false;
        static bool bandera13 = false;
        static bool bandera14 = false;
        static bool bandera15 = false;
        static bool bandera16 = false;
        static bool bandera17 = false;
        static bool bandera18 = false;
        static bool bandera19 = false;
        static bool bandera20 = false;

        public bool banderaPausa = false;
        public int velocidadChecador = 450;

        public int contadorActivos = -1;
        public int contadorPares = 0;

        public int contadorTiempo = 0;
        public int contadorContraReloj = 46;
        public int contadorTiempoMinutos = 0;
        public int contadorSegundos;

        public int modoDeJuego;

        public string[] arregloRutas = new string[20];
        public string[] arregloRutasDestapadas = new string[2];
        public int[] arregloImagenes1 = new int[10];
        public int[] arregloImagenes2 = new int[10];
        public int[] arregloNombresBotones = new int[20];
        public int[] arregloLeft=new int[20];
        public int[] arregloTop=new int[20];
        public int[] arregloMoverCartas = new int[20];
        Random aleatorio;
        Random grupoDeCartas;


        //Metodos
        int grupoDeCartas2;
        public void ObtenerGruposDeCartas()
        {
            grupoDeCartas = new Random();
            grupoDeCartas2 = grupoDeCartas.Next(1, 6);
        }

        public int[] ObtenerArreglo(int[] arreglo, int grupoDeCartas)        
        {            
            aleatorio = new Random();            
            
            
            //Llenar Arreglo
            for (int casillero = 0; casillero <= 9; casillero++)
            {
                switch (grupoDeCartas)
                {
                    case 1:
                        arreglo[casillero] = aleatorio.Next(1, 11);//1 al 10
                        break;
                    case 2:
                        arreglo[casillero] = aleatorio.Next(11, 21);//11 al 20
                        break;
                    case 3:
                        arreglo[casillero] = aleatorio.Next(21, 31);//21 al 30
                        break;
                    case 4:
                        arreglo[casillero] = aleatorio.Next(31, 41);//31 al 40
                        break;
                    case 5:
                        arreglo[casillero] = aleatorio.Next(36, 46);//35 al 45 
                        break;
                    default:
                        break;
                }                
            }            

            //Hacer que no se repitan los numeros
            for (int casillero = 0; casillero <= 9; casillero++)
            {
                for (int casillero2 = 0; casillero2 <= 9; casillero2++)
                {
                    if (casillero == casillero2)
                    {

                    }
                    else
                    {
                        if (arreglo[casillero] == arreglo[casillero2])
                        {
                            int valor=0;
                            switch (grupoDeCartas2)
                            {
                                case 1:
                                    valor = aleatorio.Next(1, 11);//1 al 10                                            
                                    break;
                                case 2:
                                    valor= aleatorio.Next(11, 21);//11 al 20                                            
                                    break;
                                case 3:
                                   valor = aleatorio.Next(21, 31);//21 al 30                                            
                                    break;
                                case 4:
                                    valor = aleatorio.Next(31, 41);//31 al 40
                                    break;
                                case 5:
                                    valor = aleatorio.Next(36, 46);//35 al 45 
                                    break;
                                default:
                                    break;
                            }

                            
                            for (int casillero3 = 0; casillero3 <= casillero; casillero3++)
                            {
                                while (valor == arreglo[casillero3])
                                {
                                    switch (grupoDeCartas2)
                                    {
                                        case 1:
                                            valor = aleatorio.Next(1, 11);//1 al 10                                            
                                            break;
                                        case 2:
                                            valor = aleatorio.Next(11, 21);//11 al 20                                            
                                            break;
                                        case 3:
                                            valor = aleatorio.Next(21, 31);//21 al 30                                            
                                            break;
                                        case 4:
                                            valor = aleatorio.Next(31, 41);//31 al 40
                                            break;
                                        case 5:
                                            valor = aleatorio.Next(36, 46);//35 al 45 
                                            break;
                                        default:
                                            break;
                                    }
                                    casillero3 = 0;
                                }
                            }
                            arreglo[casillero2] = valor;
                        }
                    }
                }
            }
            return arreglo;
        }


        public int[] ObtenerArreglo(int[] arreglo)
        {
            aleatorio = new Random();

            //Llenar Arreglo
            for (int casillero = 0; casillero <= 19; casillero++)
            {                
             arreglo[casillero] = aleatorio.Next(0, 20);//0 al 19                
            }

            //Hacer que no se repitan los numeros
            for (int casillero = 0; casillero <= 19; casillero++)
            {
                for (int casillero2 = 0; casillero2 <= 19; casillero2++)
                {
                    if (casillero == casillero2)
                    {

                    }
                    else
                    {
                        if (arreglo[casillero] == arreglo[casillero2])
                        {
                            int valor = 0;                                      
                            valor = aleatorio.Next(0, 20);//0 al 19
                            for (int casillero3 = 0; casillero3 <= casillero; casillero3++)
                            {
                                while (valor == arreglo[casillero3])
                                {                                    
                                  valor = aleatorio.Next(0, 20);//0 al 19 
                                  casillero3 = 0;
                                }
                            }
                            arreglo[casillero2] = valor;
                        }
                    }
                }
            }
            return arreglo;
        }

        public void MoverCartas()
        {
            ObtenerArreglo(arregloMoverCartas);

            //Asignar las nuevas propiedades a las imagenes
            pctImagen1.Top=arregloTop[arregloMoverCartas[0]];
            pctImagen2.Top=arregloTop[arregloMoverCartas[1]];
            pctImagen3.Top=arregloTop[arregloMoverCartas[2]];
            pctImagen4.Top=arregloTop[arregloMoverCartas[3]];
            pctImagen5.Top=arregloTop[arregloMoverCartas[4]];
            pctImagen6.Top=arregloTop[arregloMoverCartas[5]];
            pctImagen7.Top=arregloTop[arregloMoverCartas[6]];
            pctImagen8.Top=arregloTop[arregloMoverCartas[7]];
            pctImagen9.Top=arregloTop[arregloMoverCartas[8]];
            pctImagen10.Top=arregloTop[arregloMoverCartas[9]];
            pctImagen11.Top=arregloTop[arregloMoverCartas[10]];
            pctImagen12.Top=arregloTop[arregloMoverCartas[11]];
            pctImagen13.Top=arregloTop[arregloMoverCartas[12]];
            pctImagen14.Top=arregloTop[arregloMoverCartas[13]];
            pctImagen15.Top=arregloTop[arregloMoverCartas[14]];
            pctImagen16.Top=arregloTop[arregloMoverCartas[15]];
            pctImagen17.Top=arregloTop[arregloMoverCartas[16]];
            pctImagen18.Top=arregloTop[arregloMoverCartas[17]];
            pctImagen19.Top=arregloTop[arregloMoverCartas[18]];
            pctImagen20.Top = arregloTop[arregloMoverCartas[19]];

            pctImagen1.Left = arregloLeft[arregloMoverCartas[0]];
            pctImagen2.Left = arregloLeft[arregloMoverCartas[1]];
            pctImagen3.Left = arregloLeft[arregloMoverCartas[2]];
            pctImagen4.Left = arregloLeft[arregloMoverCartas[3]];
            pctImagen5.Left = arregloLeft[arregloMoverCartas[4]];
            pctImagen6.Left = arregloLeft[arregloMoverCartas[5]];
            pctImagen7.Left = arregloLeft[arregloMoverCartas[6]];
            pctImagen8.Left = arregloLeft[arregloMoverCartas[7]];
            pctImagen9.Left = arregloLeft[arregloMoverCartas[8]];
            pctImagen10.Left = arregloLeft[arregloMoverCartas[9]];
            pctImagen11.Left = arregloLeft[arregloMoverCartas[10]];
            pctImagen12.Left = arregloLeft[arregloMoverCartas[11]];
            pctImagen13.Left = arregloLeft[arregloMoverCartas[12]];
            pctImagen14.Left = arregloLeft[arregloMoverCartas[13]];
            pctImagen15.Left = arregloLeft[arregloMoverCartas[14]];
            pctImagen16.Left = arregloLeft[arregloMoverCartas[15]];
            pctImagen17.Left = arregloLeft[arregloMoverCartas[16]];
            pctImagen18.Left = arregloLeft[arregloMoverCartas[17]];
            pctImagen19.Left = arregloLeft[arregloMoverCartas[18]];
            pctImagen20.Left = arregloLeft[arregloMoverCartas[19]];
        }


        public void cerrarRapido()
        {
            if(contadorActivos==1)
            {
                taparTodos();
            }
        }


        public void obtenerNombre(string arregloRutasDestapadas)
        {
            switch (arregloRutasDestapadas)
            {
                case @"..\..\Imagenes\1.jpg": 
                    txtNombre.Text="Rayos del Necaxa";
                    txtNombre.BackColor = System.Drawing.Color.Red;
                    txtNombre.ForeColor = System.Drawing.Color.White;
                    break;
                case @"..\..\Imagenes\2.jpg":
                    txtNombre.Text = "Aguilas del America";
                    txtNombre.BackColor = System.Drawing.Color.Blue;
                    txtNombre.ForeColor = System.Drawing.Color.Yellow;
                    break;
                case  @"..\..\Imagenes\3.jpg":
                    txtNombre.Text = "Chivas Rayadas del Guadalajara";
                    txtNombre.BackColor = System.Drawing.Color.Red;
                    txtNombre.ForeColor = System.Drawing.Color.White;
                    break;
                case @"..\..\Imagenes\4.jpg":
                    txtNombre.Text = "Gladiadores del San Luis";
                    txtNombre.BackColor = System.Drawing.Color.Gold;
                    txtNombre.ForeColor = System.Drawing.Color.Blue;
                    break;
                case @"..\..\Imagenes\5.jpg":
                    txtNombre.Text = "Rojinegros del Atlas";
                    txtNombre.BackColor = System.Drawing.Color.Red;
                    txtNombre.ForeColor = System.Drawing.Color.Black;
                    break;
                case @"..\..\Imagenes\6.jpg":
                    txtNombre.Text = "Potros de Hierro del Atlante";
                    txtNombre.BackColor = System.Drawing.Color.Violet;
                    txtNombre.ForeColor = System.Drawing.Color.Red;
                    break;
                case @"..\..\Imagenes\7.jpg":
                    txtNombre.Text = "Guerreros del Santos Laguna";
                    txtNombre.BackColor = System.Drawing.Color.Green;
                    txtNombre.ForeColor = System.Drawing.Color.White;                    
                    break;
                case @"..\..\Imagenes\8.jpg":
                    txtNombre.Text = "Tuzos del Pachuca";
                    txtNombre.BackColor = System.Drawing.Color.Blue;
                    txtNombre.ForeColor = System.Drawing.Color.White;                    
                    break;
                case @"..\..\Imagenes\9.jpg":
                    txtNombre.Text = "Rayados del Monterrey";
                    txtNombre.BackColor = System.Drawing.Color.Blue;
                    txtNombre.ForeColor = System.Drawing.Color.White;
                    break;
                case @"..\..\Imagenes\10.jpg":
                    txtNombre.Text = "Indios de Cd. Juarez";
                    txtNombre.BackColor = System.Drawing.Color.Red;
                    txtNombre.ForeColor = System.Drawing.Color.White;
                    break;
                case @"..\..\Imagenes\11.jpg":
                    txtNombre.Text = "Puebla";
                    txtNombre.BackColor = System.Drawing.Color.LightBlue;
                    txtNombre.ForeColor = System.Drawing.Color.White;
                    break;
                case @"..\..\Imagenes\12.jpg":
                    txtNombre.Text = "Pumas de la UNAM";
                    txtNombre.BackColor = System.Drawing.Color.Gold;
                    txtNombre.ForeColor = System.Drawing.Color.DarkBlue;
                    break;
                case @"..\..\Imagenes\13.jpg":
                    txtNombre.Text = "La Maquina del Cruz Azul";
                    txtNombre.BackColor = System.Drawing.Color.White;
                    txtNombre.ForeColor = System.Drawing.Color.Blue;
                    break;
                case @"..\..\Imagenes\14.jpg":
                    txtNombre.Text = "Tecos de la UAG";
                    txtNombre.BackColor = System.Drawing.Color.Yellow;
                    txtNombre.ForeColor = System.Drawing.Color.Red;
                    break;
                case @"..\..\Imagenes\15.jpg":
                    txtNombre.Text = "Monarcas del Morelia";
                    txtNombre.BackColor = System.Drawing.Color.Yellow;
                    txtNombre.ForeColor = System.Drawing.Color.Red;
                    break;
                case @"..\..\Imagenes\16.jpg":
                    txtNombre.Text = "Diablos Rojos del Toluca";
                    txtNombre.BackColor = System.Drawing.Color.Red;
                    txtNombre.ForeColor = System.Drawing.Color.White;
                    break;
                case @"..\..\Imagenes\17.jpg":
                    txtNombre.Text = "Tigres de la UANL";
                    txtNombre.BackColor = System.Drawing.Color.Blue;
                    txtNombre.ForeColor = System.Drawing.Color.Yellow;
                    break;
                case @"..\..\Imagenes\18.jpg":
                    txtNombre.Text = "Jaguares de Chiapas";
                    txtNombre.BackColor = System.Drawing.Color.Orange;
                    txtNombre.ForeColor = System.Drawing.Color.White;
                    break;
                case @"..\..\Imagenes\19.jpg":
                    txtNombre.Text = "Gallos Blancos de Queretaro";
                    txtNombre.BackColor = System.Drawing.Color.Black;
                    txtNombre.ForeColor = System.Drawing.Color.Blue;
                    break;
                case @"..\..\Imagenes\20.jpg":
                    txtNombre.Text = "Tiburones Rojos de Veracruz";
                    txtNombre.BackColor = System.Drawing.Color.Blue;
                    txtNombre.ForeColor = System.Drawing.Color.Red;
                    break;
                case @"..\..\Imagenes\21.jpg":
                    txtNombre.Text = "Xoloizcuintles de Tijuana";
                    txtNombre.BackColor = System.Drawing.Color.Red;
                    txtNombre.ForeColor = System.Drawing.Color.Black;
                    break;
                case @"..\..\Imagenes\22.jpg":
                    txtNombre.Text = "Dorados de Sinaloa";
                    txtNombre.BackColor = System.Drawing.Color.Gold;
                    txtNombre.ForeColor = System.Drawing.Color.LightBlue;
                    break;
                case @"..\..\Imagenes\23.jpg":
                    txtNombre.Text = "Alacranes de Durango";
                    txtNombre.BackColor = System.Drawing.Color.Green;
                    txtNombre.ForeColor = System.Drawing.Color.YellowGreen;
                    break;
                case @"..\..\Imagenes\24.jpg":
                    txtNombre.Text = "Petroleros de Salamanca";
                    txtNombre.BackColor = System.Drawing.Color.Brown;
                    txtNombre.ForeColor = System.Drawing.Color.Yellow;
                    break;
                case @"..\..\Imagenes\25.jpg":
                    txtNombre.Text = "Real Colima";
                    txtNombre.BackColor = System.Drawing.Color.BlueViolet;
                    txtNombre.ForeColor = System.Drawing.Color.Red;
                    break;
                case @"..\..\Imagenes\26.jpg":
                    txtNombre.Text = "Atletico Mexiquense";
                    txtNombre.BackColor = System.Drawing.Color.Red;
                    txtNombre.ForeColor = System.Drawing.Color.White;
                    break;
                case @"..\..\Imagenes\27.jpg":
                    txtNombre.Text = "Lobos de la BUAP";
                    txtNombre.BackColor = System.Drawing.Color.SkyBlue;
                    txtNombre.ForeColor = System.Drawing.Color.Yellow;
                    break;
                case @"..\..\Imagenes\28.jpg":
                    txtNombre.Text = "Socio Aguila";
                    txtNombre.BackColor = System.Drawing.Color.Blue;
                    txtNombre.ForeColor = System.Drawing.Color.Yellow;
                    break;
                case @"..\..\Imagenes\29.jpg":
                    txtNombre.Text = "Freseros de Irapuato";
                    txtNombre.BackColor = System.Drawing.Color.Red;
                    txtNombre.ForeColor = System.Drawing.Color.Blue;
                    break;
                case @"..\..\Imagenes\30.jpg":
                    txtNombre.Text = "Panzas Verdes del Leon";
                    txtNombre.BackColor = System.Drawing.Color.Green;
                    txtNombre.ForeColor = System.Drawing.Color.Yellow;
                    break;
                case @"..\..\Imagenes\31.jpg":
                    txtNombre.Text = "Correcaminos";
                    txtNombre.BackColor = System.Drawing.Color.Orange;
                    txtNombre.ForeColor = System.Drawing.Color.White;
                    break;
                case @"..\..\Imagenes\32.jpg":
                    txtNombre.Text = "Cangrejos de Tampico Madero";
                    txtNombre.BackColor = System.Drawing.Color.SkyBlue;
                    txtNombre.ForeColor = System.Drawing.Color.White;
                    break;
                case @"..\..\Imagenes\33.jpg":
                    txtNombre.Text = "Monarcas Merida";
                    txtNombre.BackColor = System.Drawing.Color.Black;
                    txtNombre.ForeColor = System.Drawing.Color.LightBlue;
                    break;
                case @"..\..\Imagenes\34.jpg":
                    txtNombre.Text = "Toros Neza";
                    txtNombre.BackColor = System.Drawing.Color.Red;
                    txtNombre.ForeColor = System.Drawing.Color.White;
                    break;
                case @"..\..\Imagenes\35.jpg":
                    txtNombre.Text = "Disquin de Luma Software";
                    txtNombre.BackColor = System.Drawing.Color.Red;
                    txtNombre.ForeColor = System.Drawing.Color.Yellow;
                    break;
                case @"..\..\Imagenes\36.jpg":
                    txtNombre.Text = "Toros del Atletico Español";
                    txtNombre.BackColor = System.Drawing.Color.Black;
                    txtNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
                    break;
                case @"..\..\Imagenes\37.jpg":
                    txtNombre.Text = "Colibries de Cuernavaca";
                    txtNombre.BackColor = System.Drawing.Color.White;
                    txtNombre.ForeColor = System.Drawing.Color.GreenYellow;
                    break;
                case @"..\..\Imagenes\38.jpg":
                    txtNombre.Text = "Leones Negros de la U de G";
                    txtNombre.BackColor = System.Drawing.Color.Black;
                    txtNombre.ForeColor = System.Drawing.Color.Yellow;
                    break;
                case @"..\..\Imagenes\39.jpg":
                    txtNombre.Text = "Toros del Atletico Celaya";
                    txtNombre.BackColor = System.Drawing.Color.Black;
                    txtNombre.ForeColor = System.Drawing.Color.Blue;
                    break;
                case @"..\..\Imagenes\40.jpg":
                    txtNombre.Text = "Federacion Mexicana de Futbol";
                    txtNombre.BackColor = System.Drawing.Color.Green;
                    txtNombre.ForeColor = System.Drawing.Color.White;
                    break;
                case @"..\..\Imagenes\41.jpg":
                    txtNombre.Text = "Cañeros de Zacatepec";
                    txtNombre.BackColor = System.Drawing.Color.LightGreen;
                    txtNombre.ForeColor = System.Drawing.Color.White;
                    break;
                case @"..\..\Imagenes\42.jpg":
                    txtNombre.Text = "Cobras de Cd. Juarez";
                    txtNombre.BackColor = System.Drawing.Color.Orange;
                    txtNombre.ForeColor = System.Drawing.Color.Black;
                    break;
                case @"..\..\Imagenes\43.jpg":
                    txtNombre.Text = "Club Oro de Jalisco";
                    txtNombre.BackColor = System.Drawing.Color.Gold;
                    txtNombre.ForeColor = System.Drawing.Color.Purple;
                    break;
                case @"..\..\Imagenes\44.jpg":
                    txtNombre.Text = "Primera Division 'A'";
                    txtNombre.BackColor = System.Drawing.Color.White;
                    txtNombre.ForeColor = System.Drawing.Color.Purple;
                    break;
                case @"..\..\Imagenes\45.jpg":
                    txtNombre.Text = "Primera Division";
                    txtNombre.BackColor = System.Drawing.Color.Green;
                    txtNombre.ForeColor = System.Drawing.Color.White;
                    break;
                default:
                    break;
            }
        }


        public void revisarContador(string ruta)
        {
            txtValor.Text = contadorActivos.ToString();                
                if (contadorActivos == 1)
                {             
                    revisarCorrectos();                    
                    if (contadorActivos == -1)
                    {
                        InhabilitarTodo();
                        tmContador.Stop();
                        MessageBox.Show("Vas demasiado rapido, espera a que cierre las cartas");
                        taparTodos();
                        tmContador.Start();
                    }
                    else
                    {
                        arregloRutasDestapadas[contadorActivos] = ruta;                        
                    }
                    taparTodos();
                }
                else
                {
                    HabilitarTodo();
                    contadorActivos++;
                    arregloRutasDestapadas[contadorActivos] = ruta;
                }
            
        }

        public void revisarCorrectos()
        {
            //revisar si las rutas son iguales
            contadorActivos = -1;            
            if (arregloRutasDestapadas[0]==arregloRutasDestapadas[1])
            {
                //Moatrar contador de Pares
                if (contadorPares==9)
                {
                    contadorPares = 10;
                    OcultarTodo();
                    txtPares.Text = contadorPares.ToString();
                    tmContador.Stop();
                    MessageBox.Show("FELICIDADES GANASTE");
                    
                    //Detener todos los relojitos
                    tmChecador.Stop();
                    tmContador.Stop();
                    banderaPausa = true;
                
                    //Mandar a Llamar a la ventana de Records
                    int juego=0;
                    if (modoDeJuego == 4)
                    {
                        juego = 4;
                        contadorSegundos = 45 - int.Parse(txtContraReloj.Text);
                    }
                    else
                    {
                        switch (velocidadChecador)
                        {
                            case 150://Rapido
                                juego = 3;
                                break;
                            case 450://Normal
                                juego = 1;
                                break;
                            case 750://Rapido
                                juego = 2;
                                break;
                            default:
                                break;
                        }
                    }
                    Records record = new Records(contadorSegundos,true,juego);
                    record.ShowDialog();
                }
                else
                {
                    contadorPares++;
                }
                
                txtPares.Text = contadorPares.ToString();
                //Revisar que botones tienen esa ruta
                if (pctImagen1.ImageLocation == null) { }
                else
                {
                    if (pctImagen1.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen1.Visible = false;
                }
                if (pctImagen2.ImageLocation == null) { }
                else
                {
                    if (pctImagen2.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen2.Visible = false;
                }
                if (pctImagen3.ImageLocation == null) { }
                else
                {
                    if (pctImagen3.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen3.Visible = false;
                }
                if (pctImagen4.ImageLocation == null) { }
                else
                {
                    if (pctImagen4.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen4.Visible = false;
                }
                if (pctImagen5.ImageLocation == null) { }
                else
                {
                    if (pctImagen5.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen5.Visible = false;
                }
                if (pctImagen6.ImageLocation == null) { }
                else
                {
                    if (pctImagen6.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen6.Visible = false;
                }
                if (pctImagen7.ImageLocation == null) { }
                else
                {
                    if (pctImagen7.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen7.Visible = false;
                }
                if (pctImagen8.ImageLocation == null) { }
                else
                {
                    if (pctImagen8.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen8.Visible = false;
                }
                if (pctImagen9.ImageLocation == null) { }
                else
                {
                    if (pctImagen9.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen9.Visible = false;
                }
                if (pctImagen10.ImageLocation == null) { }
                else
                {
                    if (pctImagen10.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen10.Visible = false;
                }
                if (pctImagen11.ImageLocation == null) { }
                else
                {
                    if (pctImagen11.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen11.Visible = false;
                }
                if (pctImagen12.ImageLocation == null) { }
                else
                {
                    if (pctImagen12.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen12.Visible = false;
                }
                if (pctImagen13.ImageLocation == null) { }
                else
                {
                    if (pctImagen13.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen13.Visible = false;
                }
                if (pctImagen14.ImageLocation == null) { }
                else
                {
                    if (pctImagen14.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen14.Visible = false;
                }
                if (pctImagen15.ImageLocation == null) { }
                else
                {
                    if (pctImagen15.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen15.Visible = false;
                }
                if (pctImagen16.ImageLocation == null) { }
                else
                {
                    if (pctImagen16.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen16.Visible = false;
                }
                if (pctImagen17.ImageLocation == null) { }
                else
                {
                    if (pctImagen17.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen17.Visible = false;
                }
                if (pctImagen18.ImageLocation == null) { }
                else
                {
                    if (pctImagen18.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen18.Visible = false;
                }
                if (pctImagen19.ImageLocation == null) { }
                else
                {
                    if (pctImagen19.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen19.Visible = false;
                }
                if (pctImagen20.ImageLocation == null) { }
                else
                {
                    if (pctImagen20.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen20.Visible = false;
                }
            }
            
        }
            

        public void taparTodos()
        {
            /*Manejar rutas relativas ayudara a que el programa se ejecute en cualquier localizacion de una computadora
            y lo mejor en cualquier computadora sin necesidad de crear la ruta absoluta*/
            pctImagen1.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\"+0+".jpg");
            pctImagen2.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen3.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen4.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen5.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen6.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen7.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen8.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen9.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen10.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\"+0+".jpg");           
            pctImagen11.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen12.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen13.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen14.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen15.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen16.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen17.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen18.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen19.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen20.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");

            txtNombre.Text = "";
            txtNombre.ForeColor = System.Drawing.Color.White;
            HabilitarTodo();
        }
        public void HabilitarTodo()
        {
            pctImagen1.Enabled = true;
            pctImagen2.Enabled = true;
            pctImagen3.Enabled = true;
            pctImagen4.Enabled = true;
            pctImagen5.Enabled = true;
            pctImagen6.Enabled = true;
            pctImagen7.Enabled = true;
            pctImagen8.Enabled = true;
            pctImagen9.Enabled = true;
            pctImagen10.Enabled = true;
            pctImagen11.Enabled = true;
            pctImagen12.Enabled = true;
            pctImagen13.Enabled = true;
            pctImagen14.Enabled = true;
            pctImagen15.Enabled = true;
            pctImagen16.Enabled = true;
            pctImagen17.Enabled = true;
            pctImagen18.Enabled = true;
            pctImagen19.Enabled = true;
            pctImagen20.Enabled = true;
        }
        public void OcultarTodo()
        {
            pctImagen1.Visible = false;
            pctImagen2.Visible = false;
            pctImagen3.Visible = false;
            pctImagen4.Visible = false;
            pctImagen5.Visible = false;
            pctImagen6.Visible = false;
            pctImagen7.Visible = false;
            pctImagen8.Visible = false;
            pctImagen9.Visible= false;
            pctImagen10.Visible =false;
            pctImagen11.Visible =false;
            pctImagen12.Visible =false;
            pctImagen13.Visible=false;
            pctImagen14.Visible =false;
            pctImagen15.Visible =false;
            pctImagen16.Visible =false;
            pctImagen17.Visible=false;
            pctImagen18.Visible=false;
            pctImagen19.Visible=false;
            pctImagen20.Visible=false;
        }
        public void MostrarTodo()
        {
            pctImagen1.Visible = true;
            pctImagen2.Visible = true;
            pctImagen3.Visible = true;
            pctImagen4.Visible = true;
            pctImagen5.Visible = true;
            pctImagen6.Visible = true;
            pctImagen7.Visible = true;
            pctImagen8.Visible = true;
            pctImagen9.Visible = true;
            pctImagen10.Visible = true;
            pctImagen11.Visible = true;
            pctImagen12.Visible = true;
            pctImagen13.Visible = true;
            pctImagen14.Visible = true;
            pctImagen15.Visible = true;
            pctImagen16.Visible = true;
            pctImagen17.Visible = true;
            pctImagen18.Visible = true;
            pctImagen19.Visible = true;
            pctImagen20.Visible = true;
        }
        public void InhabilitarTodo()
        {
            pctImagen1.Enabled = false;
            pctImagen2.Enabled = false;
            pctImagen3.Enabled = false;
            pctImagen4.Enabled = false;
            pctImagen5.Enabled = false;
            pctImagen6.Enabled = false;
            pctImagen7.Enabled = false;
            pctImagen8.Enabled = false;
            pctImagen9.Enabled = false;
            pctImagen10.Enabled = false;
            pctImagen11.Enabled = false;
            pctImagen12.Enabled = false;
            pctImagen13.Enabled = false;
            pctImagen14.Enabled = false;
            pctImagen15.Enabled = false;
            pctImagen16.Enabled = false;
            pctImagen17.Enabled = false;
            pctImagen18.Enabled = false;
            pctImagen19.Enabled = false;
            pctImagen20.Enabled = false;
        }

        public void EmpezarJuego()
        {
            banderaPausa = false;            
            contadorActivos = -1;
            contadorPares = 0;
            contadorTiempo = 0;
            contadorTiempoMinutos = 0;
            txtPares.Text = contadorPares.ToString();
            ObtenerGruposDeCartas();
            Asignacion(ObtenerArreglo(arregloImagenes1, grupoDeCartas2));
            Asignacion(ObtenerArreglo(arregloImagenes2, grupoDeCartas2));
            LlenarArregloTopLeft(arregloTop, 1);
            LlenarArregloTopLeft(arregloLeft,2);
            MoverCartas();
            MostrarTodo();
            taparTodos();
            txtTiempo.Text = contadorTiempoMinutos.ToString() + " min " + contadorTiempo.ToString() + " seg";
            tmContador.Start();
            tmChecador.Start();
        }

        public void LlenarArregloTopLeft(int[] arreglo,int propiedad)
        {
            //1 es Top, 2 es Left
            if (propiedad==1)
            {
                arreglo[0] = pctImagen1.Top;
                arreglo[1] = pctImagen2.Top;
                arreglo[2] = pctImagen3.Top;
                arreglo[3] = pctImagen4.Top;
                arreglo[4] = pctImagen5.Top;
                arreglo[5] = pctImagen6.Top;
                arreglo[6] = pctImagen7.Top;
                arreglo[7] = pctImagen8.Top;
                arreglo[8] = pctImagen9.Top;
                arreglo[9] = pctImagen10.Top;
                arreglo[10] = pctImagen11.Top;
                arreglo[11] = pctImagen12.Top;
                arreglo[12] = pctImagen13.Top;
                arreglo[13] = pctImagen14.Top;
                arreglo[14] = pctImagen15.Top;
                arreglo[15] = pctImagen16.Top;
                arreglo[16] = pctImagen17.Top;
                arreglo[17] = pctImagen18.Top;
                arreglo[18] = pctImagen19.Top;
                arreglo[19] = pctImagen20.Top;

            }

            if (propiedad==2)
            {
                arreglo[0] = pctImagen1.Left;
                arreglo[1] = pctImagen2.Left;
                arreglo[2] = pctImagen3.Left;
                arreglo[3] = pctImagen4.Left;
                arreglo[4] = pctImagen5.Left;
                arreglo[5] = pctImagen6.Left;
                arreglo[6] = pctImagen7.Left;
                arreglo[7] = pctImagen8.Left;
                arreglo[8] = pctImagen9.Left;
                arreglo[9] = pctImagen10.Left;
                arreglo[10] = pctImagen11.Left;
                arreglo[11] = pctImagen12.Left;
                arreglo[12] = pctImagen13.Left;
                arreglo[13] = pctImagen14.Left;
                arreglo[14] = pctImagen15.Left;
                arreglo[15] = pctImagen16.Left;
                arreglo[16] = pctImagen17.Left;
                arreglo[17] = pctImagen18.Left;
                arreglo[18] = pctImagen19.Left;
                arreglo[19] = pctImagen20.Left; 
            }            
        }


      /*  public void renombrar()
        {
            pctImagen1.Name = "1";
            pctImagen2.Name = "2";
            pctImagen3.Name = "3";
            pctImagen4.Name = "4";
            pctImagen5.Name = "5";
            pctImagen6.Name = "6";
            pctImagen7.Name = "7";
            pctImagen8.Name = "8";
            pctImagen9.Name = "9";
            pctImagen10.Name = "10";
            pctImagen11.Name = "11";
            pctImagen12.Name = "12";
            pctImagen13.Name = "13";
            pctImagen14.Name = "14";
            pctImagen15.Name = "15";
            pctImagen16.Name = "16";
            pctImagen17.Name = "17";
            pctImagen18.Name = "18";
            pctImagen19.Name = "19";
            pctImagen20.Name = "20";

            pctImagen1.Name = "pctImagen" + arregloNombresBotones[0].ToString();
            pctImagen2.Name = "pctImagen" + arregloNombresBotones[1].ToString();
            pctImagen3.Name = "pctImagen" + arregloNombresBotones[2].ToString();
            pctImagen4.Name = "pctImagen" + arregloNombresBotones[3].ToString();
            pctImagen5.Name = "pctImagen" + arregloNombresBotones[4].ToString();
            pctImagen6.Name = "pctImagen" + arregloNombresBotones[5].ToString();
            pctImagen7.Name = "pctImagen" + arregloNombresBotones[6].ToString();
            pctImagen8.Name = "pctImagen" + arregloNombresBotones[7].ToString();
            pctImagen9.Name = "pctImagen" + arregloNombresBotones[8].ToString();
            pctImagen10.Name = "pctImagen" + arregloNombresBotones[9].ToString();
            pctImagen11.Name = "pctImagen" + arregloNombresBotones[10].ToString();
            pctImagen12.Name = "pctImagen" + arregloNombresBotones[11].ToString();
            pctImagen13.Name = "pctImagen" + arregloNombresBotones[12].ToString();
            pctImagen14.Name = "pctImagen" + arregloNombresBotones[13].ToString();
            pctImagen15.Name = "pctImagen" + arregloNombresBotones[14].ToString();
            pctImagen16.Name = "pctImagen" + arregloNombresBotones[15].ToString();
            pctImagen17.Name = "pctImagen" + arregloNombresBotones[16].ToString();
            pctImagen18.Name = "pctImagen" + arregloNombresBotones[17].ToString();
            pctImagen19.Name = "pctImagen" + arregloNombresBotones[18].ToString();
            pctImagen20.Name = "pctImagen" + arregloNombresBotones[19].ToString();
        }*/

        /*public int[] ObtenerArregloNombres(int[] arreglo)
        {
            aleatorio = new Random();


            //Llenar Arreglo
            for (int casillero = 0; casillero <= 19; casillero++)
            {                
              arreglo[casillero] = aleatorio.Next(1, 21);//1 al 20               
            }

            //Hacer que no se repitan los numeros
            for (int casillero = 0; casillero <= 19; casillero++)
            {
                for (int casillero2 = 0; casillero2 <= 19; casillero2++)
                {
                    if (casillero == casillero2)
                    {

                    }
                    else
                    {
                        if (arreglo[casillero] == arreglo[casillero2])
                        {
                            int valor = 0;                                                           
                            valor = aleatorio.Next(1, 21);//1 al 20                                            
                            


                            for (int casillero3 = 0; casillero3 <= casillero; casillero3++)
                            {
                                while (valor == arreglo[casillero3])
                                {
                                    valor = aleatorio.Next(1, 21);//1 al 20 
                                    casillero3 = 0;
                                }
                            }
                            arreglo[casillero2] = valor;
                        }
                    }
                }
            }
            return arreglo;
        }*/



        public void Asignacion(int[] arregloImagenes)
        {
            pctImagen1.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + arregloImagenes[0] + ".jpg");
            pctImagen2.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + arregloImagenes[1] + ".jpg");
            pctImagen3.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + arregloImagenes[2] + ".jpg");
            pctImagen4.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + arregloImagenes[3] + ".jpg");
            pctImagen5.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + arregloImagenes[4] + ".jpg");
            pctImagen6.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + arregloImagenes[5] + ".jpg");
            pctImagen7.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + arregloImagenes[6] + ".jpg");
            pctImagen8.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + arregloImagenes[7] + ".jpg");
            pctImagen9.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + arregloImagenes[8] + ".jpg");
            pctImagen10.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + arregloImagenes[9] + ".jpg");
        }

        private void pctImagen1_Click(object sender, EventArgs e)
        {            
            if (bandera1 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes1[0] + ".jpg";
                revisarContador(ruta);
                
                pctImagen1.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen1.ImageLocation = ruta;
                arregloRutas[0] = @"..\..\Imagenes\" + arregloImagenes1[0] + ".jpg";

                obtenerNombre(arregloRutas[0]);                

                pctImagen1.Enabled = false;
                //bandera1 = true;
            }
         /*   else
            {
                pctImagen1.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");                
                bandera1 = false;
            }*/
        }

        private void pctImagen2_Click(object sender, EventArgs e)
        {            
            if (bandera2 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes1[1] + ".jpg";
                revisarContador(ruta);                
                pctImagen2.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen2.ImageLocation = ruta;
                arregloRutas[1] = @"..\..\Imagenes\" + arregloImagenes1[1] + ".jpg";

                obtenerNombre(arregloRutas[1]);                
                pctImagen2.Enabled = false;
                //bandera2 = true;
            }
            /*else
            {
                pctImagen2.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");                
                bandera2 = false;
            }*/

        }

        private void pctImagen3_Click(object sender, EventArgs e)
        {         
            if (bandera3 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes1[2] + ".jpg";
                revisarContador(ruta);
                pctImagen3.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen3.ImageLocation = ruta;
                arregloRutas[2] = @"..\..\Imagenes\" + arregloImagenes1[2] + ".jpg";
                
                obtenerNombre(arregloRutas[2]);                
                pctImagen3.Enabled = false;
                //bandera3 = true;
            }
            /*else
            {
                pctImagen3.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");                
                bandera3 = false;
            }*/
        }

        private void pctImagen4_Click(object sender, EventArgs e)
        {            
            if (bandera4 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes1[3] + ".jpg";
                revisarContador(ruta);
                pctImagen4.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen4.ImageLocation = ruta;
                arregloRutas[3] = @"..\..\Imagenes\" + arregloImagenes1[3] + ".jpg";
                obtenerNombre(arregloRutas[3]);                
                pctImagen4.Enabled = false;
               // bandera4 = true;
            }
           /* else
            {
                pctImagen4.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");                
                bandera4 = false;
            }*/
        }

        private void pctImagen5_Click(object sender, EventArgs e)
        {            
            if (bandera5 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes1[4] + ".jpg";
                revisarContador(ruta);
                pctImagen5.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen5.ImageLocation = ruta;
                arregloRutas[4] = @"..\..\Imagenes\" + arregloImagenes1[4] + ".jpg"; ;
                obtenerNombre(arregloRutas[4]);
                pctImagen5.Enabled = false;
               // bandera5 = true;
            }
           /* else
            {
                pctImagen5.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");                
                bandera5 = false;
            }*/

        }

        private void pctImagen10_Click(object sender, EventArgs e)
        {         
            if (bandera10 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes1[9] + ".jpg";
                revisarContador(ruta);
                pctImagen10.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen10.ImageLocation = ruta;
                arregloRutas[9] = @"..\..\Imagenes\" + arregloImagenes1[9] + ".jpg"; ;
                obtenerNombre(arregloRutas[9]);
                pctImagen10.Enabled = false;
               // bandera10 = true;
            }
          /*  else
            {
                pctImagen10.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");                
                bandera10 = false;
            }*/

        }

        private void pctImagen9_Click(object sender, EventArgs e)
        {            
            if (bandera9 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes1[8] + ".jpg";
                revisarContador(ruta);
                pctImagen9.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen9.ImageLocation = ruta;
                arregloRutas[8] = @"..\..\Imagenes\" + arregloImagenes1[8] + ".jpg"; ;
                obtenerNombre(arregloRutas[8]);
                pctImagen9.Enabled = false;
                //bandera9 = true;
            }
            /*else
            {
                pctImagen9.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");   
                bandera9 = false;
            }*/

        }

        private void pctImagen8_Click(object sender, EventArgs e)
        {            
            if (bandera8 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes1[7] + ".jpg";
                revisarContador(ruta);
                pctImagen8.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen8.ImageLocation = ruta;
                arregloRutas[7] = @"..\..\Imagenes\" + arregloImagenes1[7] + ".jpg";
                obtenerNombre(arregloRutas[7]);
                pctImagen8.Enabled = false;
                //bandera8 = true;
            }
          /*  else
            {
                pctImagen8.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");
                bandera8 = false;
            }*/

        }

        private void pctImagen6_Click(object sender, EventArgs e)
        {            
            if (bandera6 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes1[5] + ".jpg";
                revisarContador(ruta);
                pctImagen6.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen6.ImageLocation = ruta;
                arregloRutas[5] = @"..\..\Imagenes\" + arregloImagenes1[5] + ".jpg";
                obtenerNombre(arregloRutas[5]);
                pctImagen6.Enabled = false;
                //bandera6 = true;
            }
          /*  else
            {
                pctImagen6.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");
                bandera6 = false;
            }*/
        }

        private void pctImagen7_Click(object sender, EventArgs e)
        {        
            if (bandera7 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes1[6] + ".jpg";
                revisarContador(ruta);
                pctImagen7.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen7.ImageLocation = ruta;
                arregloRutas[6] = @"..\..\Imagenes\" + arregloImagenes1[6] + ".jpg";
                obtenerNombre(arregloRutas[6]);
                pctImagen7.Enabled = false;
               // bandera7 = true;
            }
           /* else
            {
                pctImagen7.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");                
                bandera7 = false;
            }*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ObtenerArregloNombres(arregloNombresBotones);
            //renombrar();            
            modoDeJuego = 1;
            EmpezarJuego();       
        }

        private void pctImagen11_Click(object sender, EventArgs e)
        {         
            if (bandera11 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes2[0] + ".jpg";
                revisarContador(ruta);
                pctImagen11.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen11.ImageLocation = ruta;
                arregloRutas[10] = ruta;
                obtenerNombre(arregloRutas[10]);
                pctImagen11.Enabled = false;
              //  bandera11 = true;
            }
           /* else
            {
                pctImagen11.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");
                bandera11 = false;
            }*/
        }

        private void pctImagen12_Click(object sender, EventArgs e)
        {          
            if (bandera12 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes2[1] + ".jpg";
                revisarContador(ruta);
                pctImagen12.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen12.ImageLocation = ruta;
                arregloRutas[11] = ruta;
                obtenerNombre(arregloRutas[11]);
                pctImagen12.Enabled = false;
              //  bandera12 = true;
            }
          /*  else
            {
                pctImagen12.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");
                bandera12 = false;
            }*/
        }

        private void pctImagen13_Click(object sender, EventArgs e)
        {          
            if (bandera13 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes2[2] + ".jpg";
                revisarContador(ruta);
                pctImagen13.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen13.ImageLocation = ruta;
                arregloRutas[12] = ruta;
                obtenerNombre(arregloRutas[12]);
                pctImagen13.Enabled = false;
           //     bandera13 = true;
           }
           /* else
            {
                pctImagen13.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");
                bandera13 = false;
            }*/
        }

        private void pctImagen14_Click(object sender, EventArgs e)
        {            
            if (bandera14 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes2[3] + ".jpg";
                revisarContador(ruta);
                pctImagen14.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen14.ImageLocation = ruta;
                arregloRutas[13] = ruta;
                obtenerNombre(arregloRutas[13]);
                pctImagen14.Enabled = false;
              //  bandera14 = true;
            }
         /*   else
            {
                pctImagen14.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");
                bandera14 = false;
            }*/
        }

        private void pctImagen15_Click(object sender, EventArgs e)
        {          
            if (bandera15 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes2[4] + ".jpg";
                revisarContador(ruta);
                pctImagen15.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen15.ImageLocation = ruta;
                arregloRutas[14] = ruta;
                obtenerNombre(arregloRutas[14]);
                pctImagen15.Enabled = false;
            //    bandera15 = true;
            }
         /*   else
            {
                pctImagen15.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");
                bandera15 = false;
            }*/

        }

        private void pctImagen20_Click(object sender, EventArgs e)
        {            
            if (bandera20 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes2[9] + ".jpg";
                revisarContador(ruta);
                pctImagen20.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen20.ImageLocation = ruta;
                arregloRutas[19] = ruta;
                obtenerNombre(arregloRutas[19]);
                pctImagen20.Enabled = false;
             //   bandera20 = true;
            }
         /*   else
            {
                pctImagen20.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");
                bandera20 = false;
            }*/
        }

        private void pctImagen19_Click(object sender, EventArgs e)
        {         
            if (bandera19 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes2[8] + ".jpg";
                revisarContador(ruta);
                pctImagen19.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen19.ImageLocation = ruta;
                arregloRutas[18] = ruta;
                obtenerNombre(arregloRutas[18]);
                pctImagen19.Enabled = false;
           //   bandera19 = true;
           }
         /*   else
            {
                pctImagen19.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");
                bandera19 = false;
            }*/

        }

        private void pctImagen18_Click(object sender, EventArgs e)
        {            
            if (bandera18 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes2[7] + ".jpg";
                revisarContador(ruta);
                pctImagen18.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen18.ImageLocation = ruta;
                arregloRutas[17] = ruta;
                obtenerNombre(arregloRutas[17]);
                pctImagen18.Enabled = false;
             //   bandera18 = true;
            }
          /*  else
            {
                pctImagen18.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");
                bandera18 = false;
            }*/

        }

        private void pctImagen17_Click(object sender, EventArgs e)
        {            
            if (bandera17 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes2[6] + ".jpg";
                revisarContador(ruta);
                pctImagen17.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen17.ImageLocation = ruta;
                arregloRutas[16] = ruta;
                obtenerNombre(arregloRutas[16]);
                pctImagen17.Enabled = false;
             //   bandera17 = true;
            }
         /*   else
            {
                pctImagen17.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");
                bandera17 = false;
            }*/

        }

        private void pctImagen16_Click(object sender, EventArgs e)
        {          
            if (bandera16 == false)//esta tapado
            {
                cerrarRapido();
                string ruta = @"..\..\Imagenes\" + arregloImagenes2[5] + ".jpg";
                revisarContador(ruta);
                pctImagen16.Image = System.Drawing.Image.FromFile(ruta);
                pctImagen16.ImageLocation = ruta;
                arregloRutas[15] = ruta;
                obtenerNombre(arregloRutas[15]);
                pctImagen16.Enabled = false;
             //   bandera16 = true;
            }
            /*else
            {
                pctImagen16.Image = System.Drawing.Image.FromFile(@"C:\Documents and Settings\OEM System\Escritorio\Memorama\Memorama\Imagenes\" + 0 + ".jpg");
                bandera16 = false;
            }*/
        }

        private void tmChecador_Tick(object sender, EventArgs e)
        {
            tmChecador.Interval = velocidadChecador;
            if (contadorActivos==1)
            {
               //tmChecador.Interval = 1;
               //InhabilitarTodo();
               revisarCorrectos();                
               taparTodos();
            }

            if (contadorActivos==-1)
            {
                if (pctImagen1.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen1.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen2.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen2.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen3.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen3.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen4.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen4.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen5.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen5.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen6.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen6.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen7.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen7.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen8.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen8.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen9.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen9.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen10.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen10.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen11.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen11.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen12.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen12.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen13.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen13.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen14.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen14.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen15.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen15.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen16.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen16.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen17.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen17.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen18.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen18.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen19.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen19.ImageLocation=@"..\..\Imagenes\0.jpg";
                }

                if (pctImagen20.ImageLocation!=@"..\..\Imagenes\0.jpg")
                {
                    pctImagen20.ImageLocation = @"..\..\Imagenes\0.jpg";
                }


            }
        }

        private void tmContador_Tick(object sender, EventArgs e)
        {            
            switch (modoDeJuego)
            {
                case 1:
                    tmContador.Start();
                    if (contadorTiempo <= 59)
                    {
                        contadorTiempo++;
                        txtTiempo.Text = contadorTiempoMinutos.ToString() + " min " + contadorTiempo.ToString() + " seg";
                    }

                    if (contadorTiempo == 60)
                    {
                        contadorTiempo = 0;
                        contadorTiempoMinutos++;
                        contadorTiempo++;
                        txtTiempo.Text = contadorTiempoMinutos.ToString() + " min " + contadorTiempo.ToString() + " seg";
                    }

                    contadorSegundos = contadorTiempoMinutos * 60 + contadorTiempo;
                    break;
                case 4:
                    txtTiempo.ForeColor = System.Drawing.Color.Black;
                    txtTiempo.BackColor = System.Drawing.Color.Gold;               
                    txtTiempo.Text = "CONTRARELOJ";
                    tmContador.Start();
                    txtContraReloj.Text = contadorContraReloj.ToString();
                    contadorContraReloj--;
                    txtContraReloj.Text = contadorContraReloj.ToString();
                    if (contadorContraReloj<=10)
                    {
                        txtContraReloj.ForeColor = System.Drawing.Color.Red;
                    }
                    if (contadorContraReloj==0)
                    {
                        tmContador.Stop();
                        MessageBox.Show("Lo Sentimos el tiempo se te ha terminado");
                        banderaPausa = true;
                        InhabilitarTodo();
                        tmContador.Stop();
                    }
                    break;
                default:
                    break;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea empezar un Juego Nuevo?", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                txtContraReloj.Visible = false;                
                modoDeJuego = 1;
                EmpezarJuego();
            }
        }


        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modoDeJuego == 4 && contadorContraReloj == 0)
            {
                banderaPausa = true;
            }
            else
            {
                if (banderaPausa == false)
                {
                    tmContador.Stop();
                    InhabilitarTodo();
                    pausarToolStripMenuItem.Checked = true;
                    banderaPausa = true;
                    Form1.ActiveForm.Text += " - Juego Pausado";
                }
                else
                {
                    tmContador.Start();
                    HabilitarTodo();
                    pausarToolStripMenuItem.Checked = false;
                    banderaPausa = false;
                    Form1.ActiveForm.Text = "LuMa Software - Memorama Futbolero";
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Text += "LuMa Software -Memorama Futbolero - Velocidad Lenta";
            tmContador.Stop();
           
            if (MessageBox.Show("¿Seguro que desea empezar un Juego Nuevo en Velocidad Lenta?" + "\r" + "Considera que las cartas se volveran a sortear", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                txtContraReloj.Visible = false;
                velocidadChecador = 750;
                lentoToolStripMenuItem.Checked = true;
                normalToolStripMenuItem.Checked = false;
                rapidoToolStripMenuItem.Checked = false;
                modoDeJuego = 1;
                EmpezarJuego();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Text += "LuMa Software -Memorama Futbolero - Velocidad Normal";
            tmContador.Stop();
            if (MessageBox.Show("¿Seguro que desea empezar un Juego Nuevo en Velocidad Normal?" + "\r" + "Considera que las cartas se volveran a sortear", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                txtContraReloj.Visible = false;
                velocidadChecador = 450;
                lentoToolStripMenuItem.Checked = false;
                normalToolStripMenuItem.Checked = true;
                rapidoToolStripMenuItem.Checked = false;
                modoDeJuego = 1;
                EmpezarJuego();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void rapidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Text += "LuMa Software -Memorama Futbolero - Velocidad Rapida";
            tmContador.Stop();
            if (MessageBox.Show("¿Seguro que desea empezar un Juego Nuevo en Velocidad Rapida?" + "\r" + "Considera que las cartas se volveran a sortear", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                txtContraReloj.Visible = false;
                velocidadChecador = 150;
                lentoToolStripMenuItem.Checked = false;
                normalToolStripMenuItem.Checked = false;
                rapidoToolStripMenuItem.Checked = true;                
                modoDeJuego = 1;
                EmpezarJuego();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void vSPelaoManToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vSPelaoManToolStripMenuItem.Checked==false)
            {
                vSPelaoManToolStripMenuItem.Checked = true;
                facilToolStripMenuItem.Checked = false;
            }
            ContraCompu compu = new ContraCompu();
            this.Visible = false;
            compu.Show();
        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmContador.Stop();
            tmChecador.Stop();
            int juego = 0;
            if (modoDeJuego == 4)
            {
                juego = 4;
            }
            else
            {
                switch (velocidadChecador)
                {
                    case 150://Rapido
                        juego = 3;
                        break;
                    case 450://Normal
                        juego = 1;
                        break;
                    case 750://Lento
                        juego = 2;
                        break;
                    default:
                        break;
                }
            }
            Records mostrarRecords = new Records(contadorSegundos,false,juego);                        
            mostrarRecords.ShowDialog();
            if (banderaPausa == true)
            {
                tmContador.Stop();                
            }
            else
            {
                tmChecador.Start();
                tmContador.Start();
            }
        }

        private void reiniciarRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruta = @"..\..\..\Records.txt";
            banderaPausa = true;
            int juego = 0;
            if (modoDeJuego == 4)
            {
                ruta = @"..\..\..\RecordsContraReloj.txt";
                juego = 4;
            }
            else
            {
                switch (velocidadChecador)
                {
                    case 150://Rapido
                        juego = 3;
                        ruta = @"..\..\..\RecordsLento.txt";
                        break;
                    case 450://Normal
                        juego = 1;
                        ruta = @"..\..\..\Records.txt";
                        break;
                    case 750://Lento
                        juego = 2;
                        ruta = @"..\..\..\RecordsRapido.txt";
                        break;
                    default:
                        break;
                }
            }

            Records mostrarRecords = new Records(contadorSegundos, false,juego);                        
            mostrarRecords.Show();

            if (banderaPausa == true)
            {
                tmContador.Stop();                
            }
            else
            {
                tmChecador.Start();
                tmContador.Start();
            }

            if (MessageBox.Show("¿Seguro que deseas borrar los records actuales?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (juego == 4)
                {
                    for (int casillero = 0; casillero <=2; casillero++)
                    {
                        rctReiniciar.Text += "LuMa Software";
                        rctReiniciar.Text += "\n";
                        rctReiniciar.Text += "45";
                        rctReiniciar.Text += "\n";
                    }
                }
                else
                {
                    //Escribir informacion por defecto
                    for (int casillero = 0; casillero <= 2; casillero++)
                    {
                        rctReiniciar.Text += "LuMa Software";
                        rctReiniciar.Text += "\n";
                        rctReiniciar.Text += "5000";
                        rctReiniciar.Text += "\n";
                    }
                }
              
               //Escribir contenido del rich en el archivo               
               StreamWriter writer = new StreamWriter(ruta);
               writer.WriteLine(rctReiniciar.Text.Substring(0,rctReiniciar.Text.Length-1));
               writer.Close();      
            }
            mostrarRecords.Close();
            banderaPausa = false;
            tmChecador.Start();
            tmContador.Start();
        }

        private void vSRelojToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Text = "LuMa Software - Memorama Futbolerto - Dificultad VS Reloj";
            tmContador.Stop();
            if (MessageBox.Show("¿Seguro que deseas jugar contra reloj, considera que las cartas se volveran a sortear?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtContraReloj.ForeColor = System.Drawing.Color.Black;
                vSRelojToolStripMenuItem.Checked = true;
                vSPelaoManToolStripMenuItem.Checked = false;
                facilToolStripMenuItem.Checked = false;
                txtContraReloj.Visible = true;                
                contadorContraReloj = 46;
                modoDeJuego = 4;
                EmpezarJuego();
            }
            else
            {
                tmContador.Start(); 
            }
        }

        private void facilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vSRelojToolStripMenuItem.Checked = false;
            vSPelaoManToolStripMenuItem.Checked = false;
            facilToolStripMenuItem.Checked = true;
            txtContraReloj.Visible = false;
            modoDeJuego = 1;            
            nuevoToolStripMenuItem.PerformClick();
        }

        private void juegoToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tmContador.Stop();
        }

        private void juegoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (banderaPausa == true)
            {
                tmContador.Stop();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void velocidadToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tmContador.Stop();
        }

        private void velocidadToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (banderaPausa == true)
            {
                tmContador.Stop();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void dificultadToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tmContador.Stop();
        }

        private void dificultadToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (banderaPausa == true)
            {
                tmContador.Stop();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void nuevoToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tmContador.Stop();
        }

        private void pausarToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tmContador.Stop();
        }

        private void recordsToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tmContador.Stop();
        }

        private void reiniciarRecordsToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tmContador.Stop();
        }

        private void salirToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tmContador.Stop();
        }

        private void lentoToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tmContador.Stop();
        }

        private void normalToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tmContador.Stop();
        }

        private void rapidoToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tmContador.Stop();
        }

        private void facilToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tmContador.Stop();
        }

        private void vSRelojToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tmContador.Stop();
        }

        private void vSPelaoManToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tmContador.Stop();
        }

        private void nuevoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (banderaPausa == true)
            {
                tmContador.Stop();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void pausarToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (banderaPausa == true)
            {
                tmContador.Stop();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void recordsToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (banderaPausa == true)
            {
                tmContador.Stop();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void reiniciarRecordsToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (banderaPausa == true)
            {
                tmContador.Stop();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void salirToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (banderaPausa == true)
            {
                tmContador.Stop();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void lentoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (banderaPausa == true)
            {
                tmContador.Stop();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void normalToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (banderaPausa == true)
            {
                tmContador.Stop();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void rapidoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (banderaPausa == true)
            {
                tmContador.Stop();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void facilToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (banderaPausa == true)
            {
                tmContador.Stop();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void vSRelojToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (banderaPausa == true)
            {
                tmContador.Stop();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void vSPelaoManToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (banderaPausa == true)
            {
                tmContador.Stop();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pausarToolStripMenuItem.PerformClick();            
            AcercaDe creador = new AcercaDe();
            creador.Show();           
        }

        private void ayudaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tmContador.Stop();
        }

        private void acercaDeToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tmContador.Stop();
        }

        private void ayudaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (banderaPausa == true)
            {
                tmContador.Stop();
            }
            else
            {
                tmContador.Start();
            }
        }

        private void acercaDeToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (banderaPausa == true)
            {
                tmContador.Stop();
            }
            else
            {
                tmContador.Start();
            }
        }
      }
    }
