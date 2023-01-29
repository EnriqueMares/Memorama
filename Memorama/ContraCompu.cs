using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Memorama
{
    public partial class ContraCompu : Form
    {
        public ContraCompu()
        {
            InitializeComponent();
        }
        
        //Variables Globales
        public bool banderaPausa = false;

        /*false=compu*/
        /*true=usuario*/
        public bool banderaTurnoUsuario = false;
        public Random ventajaCompu;

        public int contadorActivos = -1;
        public int contadorParesUsuario = 0;
        public int contadorParesCompu = 0;
        public int contadorParesTotales=0;

        public int contadorTiempo = 0;        
        public int contadorTiempoMinutos = 0;
        public int contadorSegundos;
        
        public string[] arregloRutas = new string[90];
        public string[] arregloRutasDesechadas = new string[90];//las que se descubren
        public string[] arregloRutasDestapadas = new string[2];

        public int[] arregloImagenes1 = new int[15];
        public int[] arregloImagenes2 = new int[15];
        public int[] arregloImagenes3 = new int[15];
        public int[] arregloImagenes4 = new int[15];
        public int[] arregloImagenes5 = new int[15];
        public int[] arregloImagenes6 = new int[15];
                
        Random aleatorio;        

        //Metodos
        public void MostrarTodo()
        { 
            //de la 1 a la 10
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

            //de la 11 a la 20
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

            //de la 21 a la 30
            pctImagen21.Visible = true;
            pctImagen22.Visible = true;
            pctImagen23.Visible = true;
            pctImagen24.Visible = true;
            pctImagen25.Visible = true;
            pctImagen26.Visible = true;
            pctImagen27.Visible = true;
            pctImagen28.Visible = true;
            pctImagen29.Visible = true;
            pctImagen30.Visible = true;

            //de la 31 a la 40
            pctImagen31.Visible = true;
            pctImagen32.Visible = true;
            pctImagen33.Visible = true;
            pctImagen34.Visible = true;
            pctImagen35.Visible = true;
            pctImagen36.Visible = true;
            pctImagen37.Visible = true;
            pctImagen38.Visible = true;
            pctImagen39.Visible = true;
            pctImagen40.Visible = true;

            //de la 41 a la 50
            pctImagen41.Visible = true;
            pctImagen42.Visible = true;
            pctImagen43.Visible = true;
            pctImagen44.Visible = true;
            pctImagen45.Visible = true;
            pctImagen46.Visible = true;
            pctImagen47.Visible = true;
            pctImagen48.Visible = true;
            pctImagen49.Visible = true;
            pctImagen50.Visible = true;


            //de la 51 a la 60
            pctImagen51.Visible = true;
            pctImagen52.Visible = true;
            pctImagen53.Visible = true;
            pctImagen54.Visible = true;
            pctImagen55.Visible = true;
            pctImagen56.Visible = true;
            pctImagen57.Visible = true;
            pctImagen58.Visible = true;
            pctImagen59.Visible = true;
            pctImagen60.Visible = true;

            //de la 61 a la 70
            pctImagen61.Visible = true;
            pctImagen62.Visible = true;
            pctImagen63.Visible = true;
            pctImagen64.Visible = true;
            pctImagen65.Visible = true;
            pctImagen66.Visible = true;
            pctImagen67.Visible = true;
            pctImagen68.Visible = true;
            pctImagen69.Visible = true;
            pctImagen70.Visible = true;

            //de la 71 a la 80
            pctImagen71.Visible = true;
            pctImagen72.Visible = true;
            pctImagen73.Visible = true;
            pctImagen74.Visible = true;
            pctImagen75.Visible = true;
            pctImagen76.Visible = true;
            pctImagen77.Visible = true;
            pctImagen78.Visible = true;
            pctImagen79.Visible = true;
            pctImagen80.Visible = true;

            //de la 81 a la 90
            pctImagen81.Visible = true;
            pctImagen82.Visible = true;
            pctImagen83.Visible = true;
            pctImagen84.Visible = true;
            pctImagen85.Visible = true;
            pctImagen86.Visible = true;
            pctImagen87.Visible = true;
            pctImagen88.Visible = true;
            pctImagen89.Visible = true;
            pctImagen90.Visible = true;
        }
        public void OcultarTodo()
        {
            //de la 1 a la 10
            pctImagen1.Visible = false;
            pctImagen2.Visible = false;
            pctImagen3.Visible = false;
            pctImagen4.Visible = false;
            pctImagen5.Visible = false;
            pctImagen6.Visible = false;
            pctImagen7.Visible = false;
            pctImagen8.Visible = false;
            pctImagen9.Visible = false;
            pctImagen10.Visible = false;

            //de la 11 a la 20
            pctImagen11.Visible = false;
            pctImagen12.Visible = false;
            pctImagen13.Visible = false;
            pctImagen14.Visible = false;
            pctImagen15.Visible = false;
            pctImagen16.Visible = false;
            pctImagen17.Visible = false;
            pctImagen18.Visible = false;
            pctImagen19.Visible = false;
            pctImagen20.Visible = false;

            //de la 21 a la 30
            pctImagen21.Visible = false;
            pctImagen22.Visible = false;
            pctImagen23.Visible = false;
            pctImagen24.Visible = false;
            pctImagen25.Visible = false;
            pctImagen26.Visible = false;
            pctImagen27.Visible = false;
            pctImagen28.Visible = false;
            pctImagen29.Visible = false;
            pctImagen30.Visible = false;
            
            //de la 31 a la 40
            pctImagen31.Visible = false;
            pctImagen32.Visible = false;
            pctImagen33.Visible = false;
            pctImagen34.Visible = false;
            pctImagen35.Visible = false;
            pctImagen36.Visible = false;
            pctImagen37.Visible = false;
            pctImagen38.Visible = false;
            pctImagen39.Visible = false;
            pctImagen40.Visible = false;
            
            //de la 41 a la 50
            pctImagen41.Visible = false;
            pctImagen42.Visible = false;
            pctImagen43.Visible = false;
            pctImagen44.Visible = false;
            pctImagen45.Visible = false;
            pctImagen46.Visible = false;
            pctImagen47.Visible = false;
            pctImagen48.Visible = false;
            pctImagen49.Visible = false;
            pctImagen50.Visible = false;
            

            //de la 51 a la 60
            pctImagen51.Visible = false;
            pctImagen52.Visible = false;
            pctImagen53.Visible = false;
            pctImagen54.Visible = false;
            pctImagen55.Visible = false;
            pctImagen56.Visible = false;
            pctImagen57.Visible = false;
            pctImagen58.Visible = false;
            pctImagen59.Visible = false;
            pctImagen60.Visible = false;

            //de la 61 a la 70
            pctImagen61.Visible = false;
            pctImagen62.Visible = false;
            pctImagen63.Visible = false;
            pctImagen64.Visible = false;
            pctImagen65.Visible = false;
            pctImagen66.Visible = false;
            pctImagen67.Visible = false;
            pctImagen68.Visible = false;
            pctImagen69.Visible = false;
            pctImagen70.Visible = false;

            //de la 71 a la 80
            pctImagen71.Visible = false;
            pctImagen72.Visible = false;
            pctImagen73.Visible = false;
            pctImagen74.Visible = false;
            pctImagen75.Visible = false;
            pctImagen76.Visible = false;
            pctImagen77.Visible = false;
            pctImagen78.Visible = false;
            pctImagen79.Visible = false;
            pctImagen80.Visible = false;

            //de la 81 a la 90
            pctImagen81.Visible = false;
            pctImagen82.Visible = false;
            pctImagen83.Visible = false;
            pctImagen84.Visible = false;
            pctImagen85.Visible = false;
            pctImagen86.Visible = false;
            pctImagen87.Visible = false;
            pctImagen88.Visible = false;
            pctImagen89.Visible = false;
            pctImagen90.Visible = false;
        }
        public void HabilitarTodo()
        {
            //de la 1 a la 10
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

            //de la 11 a la 20
            pctImagen11.Enabled = true;
            pctImagen13.Enabled = true;
            pctImagen14.Enabled = true;
            pctImagen15.Enabled = true;
            pctImagen16.Enabled = true;
            pctImagen17.Enabled = true;
            pctImagen18.Enabled = true;
            pctImagen19.Enabled = true;
            pctImagen20.Enabled = true;

            //de la 21 a la 30
            pctImagen21.Enabled = true;
            pctImagen22.Enabled = true;
            pctImagen23.Enabled = true;
            pctImagen24.Enabled = true;
            pctImagen25.Enabled = true;
            pctImagen26.Enabled = true;
            pctImagen27.Enabled = true;
            pctImagen28.Enabled = true;
            pctImagen29.Enabled = true;
            pctImagen30.Enabled = true;

            //de la 31 a la 40
            pctImagen31.Enabled = true;
            pctImagen32.Enabled = true;
            pctImagen33.Enabled = true;
            pctImagen34.Enabled = true;
            pctImagen35.Enabled = true;
            pctImagen36.Enabled = true;
            pctImagen37.Enabled = true;
            pctImagen38.Enabled = true;
            pctImagen39.Enabled = true;
            pctImagen40.Enabled = true;

            //de la 41 a la 50
            pctImagen41.Enabled = true;
            pctImagen42.Enabled = true;
            pctImagen43.Enabled = true;
            pctImagen44.Enabled = true;
            pctImagen45.Enabled = true;
            pctImagen46.Enabled = true;
            pctImagen47.Enabled = true;
            pctImagen48.Enabled = true;
            pctImagen49.Enabled = true;
            pctImagen50.Enabled = true;

            //de la 51 a la 60
            pctImagen51.Enabled = true;
            pctImagen52.Enabled = true;
            pctImagen53.Enabled = true;
            pctImagen54.Enabled = true;
            pctImagen55.Enabled = true;
            pctImagen56.Enabled = true;
            pctImagen57.Enabled = true;
            pctImagen58.Enabled = true;
            pctImagen59.Enabled = true;
            pctImagen60.Enabled = true;

            //de la 61 a la 70
            pctImagen61.Enabled = true;
            pctImagen62.Enabled = true;
            pctImagen63.Enabled = true;
            pctImagen64.Enabled = true;
            pctImagen65.Enabled = true;
            pctImagen66.Enabled = true;
            pctImagen67.Enabled = true;
            pctImagen68.Enabled = true;
            pctImagen69.Enabled = true;
            pctImagen70.Enabled = true;

            //de la 71 a la 80
            pctImagen71.Enabled = true;
            pctImagen72.Enabled = true;
            pctImagen73.Enabled = true;
            pctImagen74.Enabled = true;
            pctImagen75.Enabled = true;
            pctImagen76.Enabled = true;
            pctImagen77.Enabled = true;
            pctImagen78.Enabled = true;
            pctImagen79.Enabled = true;
            pctImagen80.Enabled = true;

            //de la 81 a la 90
            pctImagen81.Enabled = true;
            pctImagen82.Enabled = true;
            pctImagen83.Enabled = true;
            pctImagen84.Enabled = true;
            pctImagen85.Enabled = true;
            pctImagen86.Enabled = true;
            pctImagen87.Enabled = true;
            pctImagen88.Enabled = true;
            pctImagen89.Enabled = true;
            pctImagen90.Enabled = true; 
        }
        public void InHabilitarTodo()
        {
            //de la 1 a la 10
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

            //de la 11 a la 20
            pctImagen11.Enabled = false;
            pctImagen13.Enabled = false;
            pctImagen14.Enabled = false;
            pctImagen15.Enabled = false;
            pctImagen16.Enabled = false;
            pctImagen17.Enabled = false;
            pctImagen18.Enabled = false;
            pctImagen19.Enabled = false;
            pctImagen20.Enabled = false;

            //de la 21 a la 30
            pctImagen21.Enabled = false;
            pctImagen22.Enabled = false;
            pctImagen23.Enabled = false;
            pctImagen24.Enabled = false;
            pctImagen25.Enabled = false;
            pctImagen26.Enabled = false;
            pctImagen27.Enabled = false;
            pctImagen28.Enabled = false;
            pctImagen29.Enabled = false;
            pctImagen30.Enabled = false;

            //de la 31 a la 40
            pctImagen31.Enabled = false;
            pctImagen32.Enabled = false;
            pctImagen33.Enabled = false;
            pctImagen34.Enabled = false;
            pctImagen35.Enabled = false;
            pctImagen36.Enabled = false;
            pctImagen37.Enabled = false;
            pctImagen38.Enabled = false;
            pctImagen39.Enabled = false;
            pctImagen40.Enabled = false;

            //de la 41 a la 50
            pctImagen41.Enabled = false;
            pctImagen42.Enabled = false;
            pctImagen43.Enabled = false;
            pctImagen44.Enabled = false;
            pctImagen45.Enabled = false;
            pctImagen46.Enabled = false;
            pctImagen47.Enabled = false;
            pctImagen48.Enabled = false;
            pctImagen49.Enabled = false;
            pctImagen50.Enabled = false;


            //de la 51 a la 60
            pctImagen51.Enabled = false;
            pctImagen52.Enabled = false;
            pctImagen53.Enabled = false;
            pctImagen54.Enabled = false;
            pctImagen55.Enabled = false;
            pctImagen56.Enabled = false;
            pctImagen57.Enabled = false;
            pctImagen58.Enabled = false;
            pctImagen59.Enabled = false;
            pctImagen60.Enabled = false;

            //de la 61 a la 70
            pctImagen61.Enabled = false;
            pctImagen62.Enabled = false;
            pctImagen63.Enabled = false;
            pctImagen64.Enabled = false;
            pctImagen65.Enabled = false;
            pctImagen66.Enabled = false;
            pctImagen67.Enabled = false;
            pctImagen68.Enabled = false;
            pctImagen69.Enabled = false;
            pctImagen70.Enabled = false;

            //de la 71 a la 80
            pctImagen71.Enabled = false;
            pctImagen72.Enabled = false;
            pctImagen73.Enabled = false;
            pctImagen74.Enabled = false;
            pctImagen75.Enabled = false;
            pctImagen76.Enabled = false;
            pctImagen77.Enabled = false;
            pctImagen78.Enabled = false;
            pctImagen79.Enabled = false;
            pctImagen80.Enabled = false;

            //de la 81 a la 90
            pctImagen81.Enabled = false;
            pctImagen82.Enabled = false;
            pctImagen83.Enabled = false;
            pctImagen84.Enabled = false;
            pctImagen85.Enabled = false;
            pctImagen86.Enabled = false;
            pctImagen87.Enabled = false;
            pctImagen88.Enabled = false;
            pctImagen89.Enabled = false;
            pctImagen90.Enabled = false; 
        }
        public void taparTodos()
        {
            /*Manejar rutas relativas ayudara a que el programa se ejecute en cualquier localizacion de una computadora
            y lo mejor en cualquier computadora sin necesidad de crear la ruta absoluta*/

            //De la 1 a la 30
            pctImagen1.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen2.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen3.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen4.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen5.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen6.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen7.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen8.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen9.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen10.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
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
            pctImagen21.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen22.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen23.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen24.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen25.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen26.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen27.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen28.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen29.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen30.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");

            //De la 31 a la 60  
            pctImagen31.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen32.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen33.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen34.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen35.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen36.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen37.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen38.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen39.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen40.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen41.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen42.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen43.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen44.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen45.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen46.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen47.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen48.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen49.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen50.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen51.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen52.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen53.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen54.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen55.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen56.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen57.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen58.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen59.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen60.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");

            //De la 61 a la 90
            pctImagen61.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen62.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen63.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen64.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen65.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen66.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen67.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen68.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen69.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen70.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen71.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen72.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen73.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen74.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen75.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen76.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen77.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen78.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen79.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen80.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen81.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen82.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen83.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen84.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen85.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen86.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen87.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen88.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen89.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
            pctImagen90.Image = System.Drawing.Image.FromFile(@"..\..\Imagenes\" + 0 + ".jpg");
          
            txtNombre.Text = "";
            txtNombre.ForeColor = System.Drawing.Color.White;
            if (banderaTurnoUsuario == true)
            {
                HabilitarTodo();
            }
            else
            {
                InHabilitarTodo();
            }            
        }
        public void cerrarRapido()
        {
            if (contadorActivos == 1)
            {
                taparTodos();
            }
        }
        public void revisarCorrectos()
        {
            //revisar si las rutas son iguales
            contadorActivos = -1;
            if (arregloRutasDestapadas[0] == arregloRutasDestapadas[1])
            {
                //Moatrar contador de Pares
                if (contadorParesTotales == 89)
                {
                    contadorParesTotales = 90;
                    OcultarTodo();
                    //txtPares.Text = contadorPares.ToString();
                    tmContador.Stop();
                    MessageBox.Show("FELICIDADES GANASTE");

                    //Detener todos los relojitos
                    tmChecador.Stop();
                    tmContador.Stop();
                    banderaPausa = true;

                    //Mandar a Llamar a la ventana de Records                  
                    int juego = 5; 
                     
                    Records record = new Records(contadorSegundos, true, juego);
                    record.ShowDialog();
                }
                else
                {
                    if (banderaTurnoUsuario == true)
                    {
                        contadorParesUsuario++;
                    }
                    else
                    {
                        contadorParesCompu++; 
                    }
                    contadorParesTotales++;
                }

                txtPares.Text = contadorParesUsuario.ToString();
                txtParesCompu.Text = contadorParesCompu.ToString();

                //Revisar que botones tienen esa ruta
                //Del 1 al 10
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

                //Del 11 al 20
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

                //Del 21 al 30
                if (pctImagen21.ImageLocation == null) { }
                else
                {
                    if (pctImagen21.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen21.Visible = false;
                }
                if (pctImagen22.ImageLocation == null) { }
                else
                {
                    if (pctImagen22.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen22.Visible = false;
                }
                if (pctImagen23.ImageLocation == null) { }
                else
                {
                    if (pctImagen23.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen23.Visible = false;
                }
                if (pctImagen24.ImageLocation == null) { }
                else
                {
                    if (pctImagen24.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen24.Visible = false;
                }
                if (pctImagen25.ImageLocation == null) { }
                else
                {
                    if (pctImagen25.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen25.Visible = false;
                }
                if (pctImagen26.ImageLocation == null) { }
                else
                {
                    if (pctImagen26.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen26.Visible = false;
                }
                if (pctImagen27.ImageLocation == null) { }
                else
                {
                    if (pctImagen27.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen27.Visible = false;
                }
                if (pctImagen28.ImageLocation == null) { }
                else
                {
                    if (pctImagen28.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen28.Visible = false;
                }
                if (pctImagen29.ImageLocation == null) { }
                else
                {
                    if (pctImagen29.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen29.Visible = false;
                }
                if (pctImagen30.ImageLocation == null) { }
                else
                {
                    if (pctImagen30.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen30.Visible = false;
                }

                //Del 31 al 40
                if (pctImagen31.ImageLocation == null) { }
                else
                {
                    if (pctImagen31.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen31.Visible = false;
                }
                if (pctImagen32.ImageLocation == null) { }
                else
                {
                    if (pctImagen32.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen32.Visible = false;
                }
                if (pctImagen33.ImageLocation == null) { }
                else
                {
                    if (pctImagen33.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen33.Visible = false;
                }
                if (pctImagen34.ImageLocation == null) { }
                else
                {
                    if (pctImagen34.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen34.Visible = false;
                }
                if (pctImagen35.ImageLocation == null) { }
                else
                {
                    if (pctImagen35.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen35.Visible = false;
                }
                if (pctImagen36.ImageLocation == null) { }
                else
                {
                    if (pctImagen36.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen36.Visible = false;
                }
                if (pctImagen37.ImageLocation == null) { }
                else
                {
                    if (pctImagen37.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen37.Visible = false;
                }
                if (pctImagen38.ImageLocation == null) { }
                else
                {
                    if (pctImagen38.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen38.Visible = false;
                }
                if (pctImagen39.ImageLocation == null) { }
                else
                {
                    if (pctImagen39.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen39.Visible = false;
                }
                if (pctImagen40.ImageLocation == null) { }
                else
                {
                    if (pctImagen40.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen40.Visible = false;
                }

                //Del 41 al 50
                if (pctImagen41.ImageLocation == null) { }
                else
                {
                    if (pctImagen41.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen41.Visible = false;
                }
                if (pctImagen42.ImageLocation == null) { }
                else
                {
                    if (pctImagen42.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen42.Visible = false;
                }
                if (pctImagen43.ImageLocation == null) { }
                else
                {
                    if (pctImagen43.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen43.Visible = false;
                }
                if (pctImagen44.ImageLocation == null) { }
                else
                {
                    if (pctImagen44.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen44.Visible = false;
                }
                if (pctImagen45.ImageLocation == null) { }
                else
                {
                    if (pctImagen45.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen45.Visible = false;
                }
                if (pctImagen46.ImageLocation == null) { }
                else
                {
                    if (pctImagen46.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen46.Visible = false;
                }
                if (pctImagen47.ImageLocation == null) { }
                else
                {
                    if (pctImagen47.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen47.Visible = false;
                }
                if (pctImagen48.ImageLocation == null) { }
                else
                {
                    if (pctImagen48.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen48.Visible = false;
                }
                if (pctImagen49.ImageLocation == null) { }
                else
                {
                    if (pctImagen49.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen49.Visible = false;
                }
                if (pctImagen50.ImageLocation == null) { }
                else
                {
                    if (pctImagen50.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen50.Visible = false;
                }

                //Del 51 al 60
                if (pctImagen51.ImageLocation == null) { }
                else
                {
                    if (pctImagen51.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen51.Visible = false;
                }
                if (pctImagen52.ImageLocation == null) { }
                else
                {
                    if (pctImagen52.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen52.Visible = false;
                }
                if (pctImagen53.ImageLocation == null) { }
                else
                {
                    if (pctImagen53.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen53.Visible = false;
                }
                if (pctImagen54.ImageLocation == null) { }
                else
                {
                    if (pctImagen54.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen54.Visible = false;
                }
                if (pctImagen55.ImageLocation == null) { }
                else
                {
                    if (pctImagen55.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen55.Visible = false;
                }
                if (pctImagen56.ImageLocation == null) { }
                else
                {
                    if (pctImagen56.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen56.Visible = false;
                }
                if (pctImagen57.ImageLocation == null) { }
                else
                {
                    if (pctImagen57.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen57.Visible = false;
                }
                if (pctImagen58.ImageLocation == null) { }
                else
                {
                    if (pctImagen58.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen58.Visible = false;
                }
                if (pctImagen59.ImageLocation == null) { }
                else
                {
                    if (pctImagen59.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen59.Visible = false;
                }
                if (pctImagen60.ImageLocation == null) { }
                else
                {
                    if (pctImagen60.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen60.Visible = false;
                }

                //Del 61 al 70
                if (pctImagen61.ImageLocation == null) { }
                else
                {
                    if (pctImagen61.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen61.Visible = false;
                }
                if (pctImagen62.ImageLocation == null) { }
                else
                {
                    if (pctImagen62.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen62.Visible = false;
                }
                if (pctImagen63.ImageLocation == null) { }
                else
                {
                    if (pctImagen63.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen63.Visible = false;
                }
                if (pctImagen64.ImageLocation == null) { }
                else
                {
                    if (pctImagen64.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen64.Visible = false;
                }
                if (pctImagen65.ImageLocation == null) { }
                else
                {
                    if (pctImagen65.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen65.Visible = false;
                }
                if (pctImagen66.ImageLocation == null) { }
                else
                {
                    if (pctImagen66.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen66.Visible = false;
                }
                if (pctImagen67.ImageLocation == null) { }
                else
                {
                    if (pctImagen67.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen67.Visible = false;
                }
                if (pctImagen68.ImageLocation == null) { }
                else
                {
                    if (pctImagen68.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen68.Visible = false;
                }
                if (pctImagen69.ImageLocation == null) { }
                else
                {
                    if (pctImagen69.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen69.Visible = false;
                }
                if (pctImagen70.ImageLocation == null) { }
                else
                {
                    if (pctImagen70.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen70.Visible = false;
                }

                //Del 71 al 80
                if (pctImagen71.ImageLocation == null) { }
                else
                {
                    if (pctImagen71.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen71.Visible = false;
                }
                if (pctImagen72.ImageLocation == null) { }
                else
                {
                    if (pctImagen72.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen72.Visible = false;
                }
                if (pctImagen73.ImageLocation == null) { }
                else
                {
                    if (pctImagen73.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen73.Visible = false;
                }
                if (pctImagen74.ImageLocation == null) { }
                else
                {
                    if (pctImagen74.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen74.Visible = false;
                }
                if (pctImagen75.ImageLocation == null) { }
                else
                {
                    if (pctImagen75.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen75.Visible = false;
                }
                if (pctImagen76.ImageLocation == null) { }
                else
                {
                    if (pctImagen76.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen76.Visible = false;
                }
                if (pctImagen77.ImageLocation == null) { }
                else
                {
                    if (pctImagen77.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen77.Visible = false;
                }
                if (pctImagen78.ImageLocation == null) { }
                else
                {
                    if (pctImagen78.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen78.Visible = false;
                }
                if (pctImagen79.ImageLocation == null) { }
                else
                {
                    if (pctImagen79.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen79.Visible = false;
                }
                if (pctImagen80.ImageLocation == null) { }
                else
                {
                    if (pctImagen80.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen80.Visible = false;
                }

                //Del 81 al 90
                if (pctImagen81.ImageLocation == null) { }
                else
                {
                    if (pctImagen81.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen81.Visible = false;
                }
                if (pctImagen82.ImageLocation == null) { }
                else
                {
                    if (pctImagen82.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen82.Visible = false;
                }
                if (pctImagen83.ImageLocation == null) { }
                else
                {
                    if (pctImagen83.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen83.Visible = false;
                }
                if (pctImagen84.ImageLocation == null) { }
                else
                {
                    if (pctImagen84.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen84.Visible = false;
                }
                if (pctImagen85.ImageLocation == null) { }
                else
                {
                    if (pctImagen85.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen85.Visible = false;
                }
                if (pctImagen86.ImageLocation == null) { }
                else
                {
                    if (pctImagen86.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen86.Visible = false;
                }
                if (pctImagen87.ImageLocation == null) { }
                else
                {
                    if (pctImagen87.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen87.Visible = false;
                }
                if (pctImagen88.ImageLocation == null) { }
                else
                {
                    if (pctImagen88.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen88.Visible = false;
                }
                if (pctImagen89.ImageLocation == null) { }
                else
                {
                    if (pctImagen89.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen89.Visible = false;
                }
                if (pctImagen90.ImageLocation == null) { }
                else
                {
                    if (pctImagen90.ImageLocation.Equals(arregloRutasDestapadas[0]) == true)
                        pctImagen90.Visible = false;
                }
            }
            determinarTurno();
        }
        public void determinarTurno()
        {
            if (banderaTurnoUsuario == true)
            {
                banderaTurnoUsuario = false;
                InHabilitarTodo();
                txtTurnoCompu.BackColor = System.Drawing.Color.Green;
                txtTurnoUsuario.BackColor = System.Drawing.Color.Red;
            }
            else
            {                
                banderaTurnoUsuario = true;
                txtTurnoCompu.BackColor = System.Drawing.Color.Red;
                txtTurnoUsuario.BackColor = System.Drawing.Color.Green;
            }
        }

        public void revisarContador(string ruta)
        {            
                if (contadorActivos == 1)
                {             
                    revisarCorrectos();                    
                    if (contadorActivos == -1)
                    {
                        InHabilitarTodo();
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
        
        public void obtenerNombre(string arregloRutasDestapadas)
        {
            switch (arregloRutasDestapadas)
            {
                case @"..\..\Imagenes\1.jpg":
                    txtNombre.Text = "Rayos del Necaxa";
                    txtNombre.BackColor = System.Drawing.Color.Red;
                    txtNombre.ForeColor = System.Drawing.Color.White;
                    break;
                case @"..\..\Imagenes\2.jpg":
                    txtNombre.Text = "Aguilas del America";
                    txtNombre.BackColor = System.Drawing.Color.Blue;
                    txtNombre.ForeColor = System.Drawing.Color.Yellow;
                    break;
                case @"..\..\Imagenes\3.jpg":
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
        public int[] ObtenerArreglo(int[] arreglo,int inicio,int final)
        {
            aleatorio = new Random();

            //Llenar Arreglo
            for (int casillero = 0; casillero <= 14; casillero++)
            {
                arreglo[casillero] = aleatorio.Next(inicio, final+1);
            }

            //Hacer que no se repitan los numeros
            for (int casillero = 0; casillero <= 14; casillero++)
            {
                for (int casillero2 = 0; casillero2 <= 14; casillero2++)
                {
                    if (casillero == casillero2)
                    {

                    }
                    else
                    {
                        if (arreglo[casillero] == arreglo[casillero2])
                        {
                            int valor = inicio;
                            valor = aleatorio.Next(inicio, final+1);
                            for (int casillero3 = 0; casillero3 <= casillero; casillero3++)
                            {
                                while (valor == arreglo[casillero3])
                                {
                                    valor = aleatorio.Next(inicio, final+1);
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


        public void JugarCompu()
        {
            ventajaCompu.Next(0, 2); 
            /*Si sale 0 NO TIENE VENTAJA*/
            /*Si sale 1 SI TIENE VENTAJA*/
            if (Convert.ToInt16(ventajaCompu) == 0)
            {
                //No ventaja
            }
            else
            {
                //Ventaja

            }
        }

        public void ClicCompu(int baraja)
        {
            switch (baraja)
            {
               //Del 1 al 10
                case 1:
                    // pctImagen1_Click();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                
                //Del 11 al 20
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;            

                //Del 21 al 30
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    break;
                case 26:
                    break;
                case 27:
                    break;
                case 28:
                    break;
                case 29:
                    break;
                case 30:
                    break;

                //Del 31 al 40
                case 31:
                    break;
                case 32:
                    break;
                case 33:
                    break;
                case 34:
                    break;
                case 35:
                    break;
                case 36:
                    break;
                case 37:
                    break;
                case 38:
                    break;
                case 39:
                    break;
                case 40:
                    break;

                //Del 41 al 50
                case 41:
                    break;
                case 42:
                    break;
                case 43:
                    break;
                case 44:
                    break;
                case 45:
                    break;
                case 46:
                    break;
                case 47:
                    break;
                case 48:
                    break;
                case 49:
                    break;
                case 50:
                    break;

                //Del 51 al 60
                case 51:
                    break;
                case 52:
                    break;
                case 53:
                    break;
                case 54:
                    break;
                case 55:
                    break;
                case 56:
                    break;
                case 57:
                    break;
                case 58:
                    break;
                case 59:
                    break;
                case 60:
                    break;

                //Del 61 al 70
                case 61:
                    break;
                case 62:
                    break;
                case 63:
                    break;
                case 64:
                    break;
                case 65:
                    break;
                case 66:
                    break;
                case 67:
                    break;
                case 68:
                    break;
                case 69:
                    break;
                case 70:
                    break;

                //Del 71 al 80
                case 71:
                    break;
                case 72:
                    break;
                case 73:
                    break;
                case 74:
                    break;
                case 75:
                    break;
                case 76:
                    break;
                case 77:
                    break;
                case 78:
                    break;
                case 79:
                    break;
                case 80:
                    break;

                //Del 81 al 90
                case 81:
                    break;
                case 82:
                    break;
                case 83:
                    break;
                case 84:
                    break;
                case 85:
                    break;
                case 86:
                    break;
                case 87:
                    break;
                case 88:
                    break;
                case 89:
                    break;
                case 90:
                    break;   
            }
        }

        public void EmpezarJuego()
        {
            banderaPausa = false;
            contadorActivos = -1;
            contadorParesUsuario = 0;
            contadorParesCompu = 0;
            contadorParesTotales = 0;
            contadorTiempo = 0;
            contadorTiempoMinutos = 0;
            txtPares.Text = contadorParesUsuario.ToString();
            txtParesCompu.Text = contadorParesCompu.ToString();
            
            
            ObtenerArreglo(arregloImagenes1,1,15);
            ObtenerArreglo(arregloImagenes2, 16, 30);
            ObtenerArreglo(arregloImagenes3, 31, 45);
            ObtenerArreglo(arregloImagenes4, 31, 45);
            ObtenerArreglo(arregloImagenes5, 16,30 );
            ObtenerArreglo(arregloImagenes6, 1, 15);
            
            
            MostrarTodo();
            taparTodos();
            txtTiempo.Text = contadorTiempoMinutos.ToString() + " min " + contadorTiempo.ToString() + " seg";
            tmContador.Start();
            tmChecador.Start(); 
        }


        //Relojes
        private void tmChecador_Tick(object sender, EventArgs e)
        {
            if (contadorActivos == 1)
            {
                revisarCorrectos();
                taparTodos();
            }

            if (contadorActivos == -1)
            {
                //Del 1 al 10
                if (pctImagen1.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen1.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen2.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen2.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen3.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen3.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen4.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen4.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen5.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen5.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen6.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen6.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen7.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen7.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen8.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen8.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen9.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen9.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen10.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen10.ImageLocation = @"..\..\Imagenes\0.jpg";
                }

                //Del 11 al 20
                if (pctImagen11.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen11.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen12.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen12.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen13.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen13.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen14.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen14.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen15.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen15.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen16.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen16.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen17.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen17.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen18.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen18.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen19.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen19.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen20.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen20.ImageLocation = @"..\..\Imagenes\0.jpg";
                }

                //Del 21 al 30
                if (pctImagen21.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen21.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen22.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen22.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen23.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen23.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen24.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen24.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen25.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen25.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen26.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen26.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen27.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen27.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen28.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen28.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen29.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen29.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen30.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen30.ImageLocation = @"..\..\Imagenes\0.jpg";
                }

                //Del 31 al 40
                if (pctImagen31.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen31.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen32.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen32.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen33.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen33.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen34.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen34.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen35.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen35.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen36.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen36.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen37.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen37.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen38.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen38.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen39.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen39.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen40.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen40.ImageLocation = @"..\..\Imagenes\0.jpg";
                }

                //Del 41 al 50
                if (pctImagen41.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen41.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen42.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen42.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen43.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen43.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen44.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen44.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen45.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen45.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen46.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen46.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen47.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen47.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen48.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen48.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen49.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen49.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen50.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen50.ImageLocation = @"..\..\Imagenes\0.jpg";
                }

                //Del 51 al 60
                if (pctImagen51.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen51.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen52.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen52.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen53.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen53.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen54.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen54.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen55.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen55.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen56.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen56.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen57.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen57.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen58.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen58.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen59.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen59.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen60.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen60.ImageLocation = @"..\..\Imagenes\0.jpg";
                }

                //Del 61 al 70
                if (pctImagen61.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen61.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen62.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen62.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen63.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen63.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen64.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen64.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen65.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen65.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen66.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen66.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen67.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen67.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen68.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen68.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen69.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen69.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen70.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen70.ImageLocation = @"..\..\Imagenes\0.jpg";
                }

                //Del 71 al 80
                if (pctImagen71.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen71.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen72.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen72.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen73.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen73.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen74.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen74.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen75.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen75.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen76.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen76.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen77.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen77.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen78.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen78.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen79.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen79.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen80.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen80.ImageLocation = @"..\..\Imagenes\0.jpg";
                }

                //Del 81 al 90
                if (pctImagen81.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen81.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen82.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen82.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen83.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen83.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen84.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen84.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen85.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen85.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen86.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen86.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen87.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen87.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen88.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen88.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen89.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen89.ImageLocation = @"..\..\Imagenes\0.jpg";
                }
                if (pctImagen90.ImageLocation != @"..\..\Imagenes\0.jpg")
                {
                    pctImagen90.ImageLocation = @"..\..\Imagenes\0.jpg";
                }

            }
        }
        private void tmContador_Tick(object sender, EventArgs e)
        {            
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
         }
        

        //Evento Load
        private void ContraCompu_Load(object sender, EventArgs e)
        {
            banderaTurnoUsuario = true;
            EmpezarJuego();
            rctDialogo.Text = "Ja Ja Ja Ja" +"\r"+"Soy el PelaoMan y no me podras ganar";            
            txtTurnoUsuario.BackColor = System.Drawing.Color.Green;
            txtTurnoCompu.BackColor = System.Drawing.Color.Red;
        }


        //Evento Clic de los Botones
        //Del 1 al 10
        private void pctImagen1_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes1[0] + ".jpg";
            revisarContador(ruta);

            pctImagen1.ImageLocation = ruta;
            arregloRutas[0] = @"..\..\Imagenes\" + arregloImagenes1[0] + ".jpg";
            obtenerNombre(arregloRutas[0]);
            pctImagen1.Enabled = false;
        }
        private void pctImagen2_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes1[1] + ".jpg";
            revisarContador(ruta);

            pctImagen2.ImageLocation = ruta;
            arregloRutas[1] = @"..\..\Imagenes\" + arregloImagenes1[1] + ".jpg";
            obtenerNombre(arregloRutas[1]);
            pctImagen2.Enabled = false;

        }
        private void pctImagen3_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes1[2] + ".jpg";
            revisarContador(ruta);

            pctImagen3.ImageLocation = ruta;
            arregloRutas[2] = @"..\..\Imagenes\" + arregloImagenes1[2] + ".jpg";
            obtenerNombre(arregloRutas[2]);
            pctImagen3.Enabled = false;

        }
        private void pctImagen4_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes1[3] + ".jpg";
            revisarContador(ruta);

            pctImagen4.ImageLocation = ruta;
            arregloRutas[3] = @"..\..\Imagenes\" + arregloImagenes1[3] + ".jpg";
            obtenerNombre(arregloRutas[3]);
            pctImagen4.Enabled = false;
        }
        private void pctImagen5_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes1[4] + ".jpg";
            revisarContador(ruta);

            pctImagen5.ImageLocation = ruta;
            arregloRutas[4] = @"..\..\Imagenes\" + arregloImagenes1[4] + ".jpg";
            obtenerNombre(arregloRutas[4]);
            pctImagen5.Enabled = false;
        }
        private void pctImagen6_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes1[5] + ".jpg";
            revisarContador(ruta);

            pctImagen6.ImageLocation = ruta;
            arregloRutas[5] = @"..\..\Imagenes\" + arregloImagenes1[5] + ".jpg";
            obtenerNombre(arregloRutas[5]);
            pctImagen6.Enabled = false;
        }
        private void pctImagen7_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes1[6] + ".jpg";
            revisarContador(ruta);

            pctImagen7.ImageLocation = ruta;
            arregloRutas[6] = @"..\..\Imagenes\" + arregloImagenes1[6] + ".jpg";
            obtenerNombre(arregloRutas[6]);
            pctImagen7.Enabled = false;
        }
        private void pctImagen8_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes1[7] + ".jpg";
            revisarContador(ruta);

            pctImagen8.ImageLocation = ruta;
            arregloRutas[7] = @"..\..\Imagenes\" + arregloImagenes1[7] + ".jpg";
            obtenerNombre(arregloRutas[7]);
            pctImagen8.Enabled = false;
        }
        private void pctImagen9_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes1[8] + ".jpg";
            revisarContador(ruta);

            pctImagen9.ImageLocation = ruta;
            arregloRutas[8] = @"..\..\Imagenes\" + arregloImagenes1[8] + ".jpg";
            obtenerNombre(arregloRutas[8]);
            pctImagen9.Enabled = false;
        }
        private void pctImagen10_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes1[9] + ".jpg";
            revisarContador(ruta);

            pctImagen10.ImageLocation = ruta;
            arregloRutas[9] = @"..\..\Imagenes\" + arregloImagenes1[9] + ".jpg";
            obtenerNombre(arregloRutas[9]);
            pctImagen10.Enabled = false;
        }

        //Del 11 al 20
        private void pctImagen11_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes1[10] + ".jpg";
            revisarContador(ruta);

            pctImagen11.ImageLocation = ruta;
            arregloRutas[10] = @"..\..\Imagenes\" + arregloImagenes1[10] + ".jpg";
            obtenerNombre(arregloRutas[10]);
            pctImagen11.Enabled = false;
        }
        private void pctImagen12_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes1[11] + ".jpg";
            revisarContador(ruta);

            pctImagen12.ImageLocation = ruta;
            arregloRutas[11] = @"..\..\Imagenes\" + arregloImagenes1[11] + ".jpg";
            obtenerNombre(arregloRutas[11]);
            pctImagen12.Enabled = false;
        }
        private void pctImagen13_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes1[12] + ".jpg";
            revisarContador(ruta);

            pctImagen13.ImageLocation = ruta;
            arregloRutas[12] = @"..\..\Imagenes\" + arregloImagenes1[12] + ".jpg";
            obtenerNombre(arregloRutas[12]);
            pctImagen13.Enabled = false;
        }
        private void pctImagen14_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes1[13] + ".jpg";
            revisarContador(ruta);

            pctImagen14.ImageLocation = ruta;
            arregloRutas[13] = @"..\..\Imagenes\" + arregloImagenes1[13] + ".jpg";
            obtenerNombre(arregloRutas[13]);
            pctImagen14.Enabled = false;
        }
        private void pctImagen15_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes1[14] + ".jpg";
            revisarContador(ruta);

            pctImagen15.ImageLocation = ruta;
            arregloRutas[14] = @"..\..\Imagenes\" + arregloImagenes1[14] + ".jpg";
            obtenerNombre(arregloRutas[14]);
            pctImagen15.Enabled = false;
        }
        private void pctImagen16_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes2[0] + ".jpg";
            revisarContador(ruta);

            pctImagen16.ImageLocation = ruta;
            arregloRutas[15] = @"..\..\Imagenes\" + arregloImagenes2[0] + ".jpg";
            obtenerNombre(arregloRutas[15]);
            pctImagen16.Enabled = false;
        }
        private void pctImagen17_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes2[1] + ".jpg";
            revisarContador(ruta);

            pctImagen17.ImageLocation = ruta;
            arregloRutas[16] = @"..\..\Imagenes\" + arregloImagenes2[1] + ".jpg";
            obtenerNombre(arregloRutas[16]);
            pctImagen17.Enabled = false;
        }
        private void pctImagen18_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes2[2] + ".jpg";
            revisarContador(ruta);

            pctImagen18.ImageLocation = ruta;
            arregloRutas[17] = @"..\..\Imagenes\" + arregloImagenes2[2] + ".jpg";
            obtenerNombre(arregloRutas[17]);
            pctImagen18.Enabled = false;
        }
        private void pctImagen19_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes2[3] + ".jpg";
            revisarContador(ruta);

            pctImagen19.ImageLocation = ruta;
            arregloRutas[18] = @"..\..\Imagenes\" + arregloImagenes2[3] + ".jpg";
            obtenerNombre(arregloRutas[18]);
            pctImagen19.Enabled = false;
        }
        private void pctImagen20_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes2[4] + ".jpg";
            revisarContador(ruta);

            pctImagen20.ImageLocation = ruta;
            arregloRutas[19] = @"..\..\Imagenes\" + arregloImagenes2[4] + ".jpg";
            obtenerNombre(arregloRutas[19]);
            pctImagen20.Enabled = false;
        }

        //Del 21 al 30
        private void pctImagen21_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes2[5] + ".jpg";
            revisarContador(ruta);

            pctImagen21.ImageLocation = ruta;
            arregloRutas[20] = @"..\..\Imagenes\" + arregloImagenes2[5] + ".jpg";
            obtenerNombre(arregloRutas[20]);
            pctImagen21.Enabled = false;
        }
        private void pctImagen22_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes2[6] + ".jpg";
            revisarContador(ruta);

            pctImagen22.ImageLocation = ruta;
            arregloRutas[21] = @"..\..\Imagenes\" + arregloImagenes2[6] + ".jpg";
            obtenerNombre(arregloRutas[21]);
            pctImagen22.Enabled = false;
        }
        private void pctImagen23_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes2[7] + ".jpg";
            revisarContador(ruta);

            pctImagen23.ImageLocation = ruta;
            arregloRutas[22] = @"..\..\Imagenes\" + arregloImagenes2[7] + ".jpg";
            obtenerNombre(arregloRutas[22]);
            pctImagen23.Enabled = false;
        }
        private void pctImagen24_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes2[8] + ".jpg";
            revisarContador(ruta);

            pctImagen24.ImageLocation = ruta;
            arregloRutas[23] = @"..\..\Imagenes\" + arregloImagenes2[8] + ".jpg";
            obtenerNombre(arregloRutas[23]);
            pctImagen24.Enabled = false;
        }
        private void pctImagen25_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes2[9] + ".jpg";
            revisarContador(ruta);

            pctImagen25.ImageLocation = ruta;
            arregloRutas[24] = @"..\..\Imagenes\" + arregloImagenes2[9] + ".jpg";
            obtenerNombre(arregloRutas[24]);
            pctImagen25.Enabled = false;
        }
        private void pctImagen26_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes2[10] + ".jpg";
            revisarContador(ruta);

            pctImagen26.ImageLocation = ruta;
            arregloRutas[25] = @"..\..\Imagenes\" + arregloImagenes2[10] + ".jpg";
            obtenerNombre(arregloRutas[25]);
            pctImagen26.Enabled = false;
        }
        private void pctImagen27_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes2[11] + ".jpg";
            revisarContador(ruta);

            pctImagen27.ImageLocation = ruta;
            arregloRutas[26] = @"..\..\Imagenes\" + arregloImagenes2[11] + ".jpg";
            obtenerNombre(arregloRutas[26]);
            pctImagen27.Enabled = false;
        }
        private void pctImagen28_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes2[12] + ".jpg";
            revisarContador(ruta);

            pctImagen28.ImageLocation = ruta;
            arregloRutas[27] = @"..\..\Imagenes\" + arregloImagenes2[12] + ".jpg";
            obtenerNombre(arregloRutas[27]);
            pctImagen28.Enabled = false;
        }
        private void pctImagen29_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes2[13] + ".jpg";
            revisarContador(ruta);

            pctImagen29.ImageLocation = ruta;
            arregloRutas[28] = @"..\..\Imagenes\" + arregloImagenes2[13] + ".jpg";
            obtenerNombre(arregloRutas[28]);
            pctImagen29.Enabled = false;
        }
        private void pctImagen30_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes2[14] + ".jpg";
            revisarContador(ruta);

            pctImagen30.ImageLocation = ruta;
            arregloRutas[29] = @"..\..\Imagenes\" + arregloImagenes2[14] + ".jpg";
            obtenerNombre(arregloRutas[29]);
            pctImagen21.Enabled = false;
        }

        //Del 31 al 40
        private void pctImagen31_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes3[0] + ".jpg";
            revisarContador(ruta);

            pctImagen31.ImageLocation = ruta;
            arregloRutas[30] = @"..\..\Imagenes\" + arregloImagenes3[0] + ".jpg";
            obtenerNombre(arregloRutas[30]);
            pctImagen31.Enabled = false;
        }
        private void pctImagen32_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes3[1] + ".jpg";
            revisarContador(ruta);

            pctImagen32.ImageLocation = ruta;
            arregloRutas[31] = @"..\..\Imagenes\" + arregloImagenes3[1] + ".jpg";
            obtenerNombre(arregloRutas[31]);
            pctImagen32.Enabled = false;
        }
        private void pctImagen33_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes3[2] + ".jpg";
            revisarContador(ruta);

            pctImagen33.ImageLocation = ruta;
            arregloRutas[32] = @"..\..\Imagenes\" + arregloImagenes3[2] + ".jpg";
            obtenerNombre(arregloRutas[32]);
            pctImagen33.Enabled = false;
        }
        private void pctImagen34_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes3[3] + ".jpg";
            revisarContador(ruta);

            pctImagen34.ImageLocation = ruta;
            arregloRutas[33] = @"..\..\Imagenes\" + arregloImagenes3[3] + ".jpg";
            obtenerNombre(arregloRutas[33]);
            pctImagen34.Enabled = false;
        }
        private void pctImagen35_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes3[4] + ".jpg";
            revisarContador(ruta);

            pctImagen35.ImageLocation = ruta;
            arregloRutas[34] = @"..\..\Imagenes\" + arregloImagenes3[4] + ".jpg";
            obtenerNombre(arregloRutas[34]);
            pctImagen35.Enabled = false;
        }
        private void pctImagen36_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes3[5] + ".jpg";
            revisarContador(ruta);

            pctImagen36.ImageLocation = ruta;
            arregloRutas[35] = @"..\..\Imagenes\" + arregloImagenes3[5] + ".jpg";
            obtenerNombre(arregloRutas[35]);
            pctImagen36.Enabled = false;   
        }
        private void pctImagen37_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes3[6] + ".jpg";
            revisarContador(ruta);

            pctImagen37.ImageLocation = ruta;
            arregloRutas[36] = @"..\..\Imagenes\" + arregloImagenes3[6] + ".jpg";
            obtenerNombre(arregloRutas[36]);
            pctImagen37.Enabled = false;
        }
        private void pctImagen38_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes3[7] + ".jpg";
            revisarContador(ruta);

            pctImagen38.ImageLocation = ruta;
            arregloRutas[37] = @"..\..\Imagenes\" + arregloImagenes3[7] + ".jpg";
            obtenerNombre(arregloRutas[37]);
            pctImagen38.Enabled = false;
        }
        private void pctImagen39_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes3[8] + ".jpg";
            revisarContador(ruta);

            pctImagen39.ImageLocation = ruta;
            arregloRutas[38] = @"..\..\Imagenes\" + arregloImagenes3[8] + ".jpg";
            obtenerNombre(arregloRutas[38]);
            pctImagen39.Enabled = false;
        }
        private void pctImagen40_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes3[9] + ".jpg";
            revisarContador(ruta);

            pctImagen40.ImageLocation = ruta;
            arregloRutas[39] = @"..\..\Imagenes\" + arregloImagenes3[9] + ".jpg";
            obtenerNombre(arregloRutas[39]);
            pctImagen40.Enabled = false;
        }

        //Del 41 al 50
        private void pctImagen41_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes3[10] + ".jpg";
            revisarContador(ruta);

            pctImagen41.ImageLocation = ruta;
            arregloRutas[40] = @"..\..\Imagenes\" + arregloImagenes3[10] + ".jpg";
            obtenerNombre(arregloRutas[40]);
            pctImagen41.Enabled = false;
        }
        private void pctImagen42_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes3[11] + ".jpg";
            revisarContador(ruta);

            pctImagen42.ImageLocation = ruta;
            arregloRutas[41] = @"..\..\Imagenes\" + arregloImagenes3[11] + ".jpg";
            obtenerNombre(arregloRutas[41]);
            pctImagen42.Enabled = false;
        }
        private void pctImagen43_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes3[12] + ".jpg";
            revisarContador(ruta);

            pctImagen43.ImageLocation = ruta;
            arregloRutas[42] = @"..\..\Imagenes\" + arregloImagenes3[12] + ".jpg";
            obtenerNombre(arregloRutas[42]);
            pctImagen43.Enabled = false;
        }
        private void pctImagen44_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes3[13] + ".jpg";
            revisarContador(ruta);

            pctImagen44.ImageLocation = ruta;
            arregloRutas[43] = @"..\..\Imagenes\" + arregloImagenes3[13] + ".jpg";
            obtenerNombre(arregloRutas[43]);
            pctImagen44.Enabled = false;
        }
        private void pctImagen45_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes3[14] + ".jpg";
            revisarContador(ruta);

            pctImagen45.ImageLocation = ruta;
            arregloRutas[44] = @"..\..\Imagenes\" + arregloImagenes3[14] + ".jpg";
            obtenerNombre(arregloRutas[44]);
            pctImagen45.Enabled = false;
        }
        private void pctImagen46_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes4[0] + ".jpg";
            revisarContador(ruta);

            pctImagen46.ImageLocation = ruta;
            arregloRutas[45] = @"..\..\Imagenes\" + arregloImagenes4[0] + ".jpg";
            obtenerNombre(arregloRutas[45]);
            pctImagen46.Enabled = false;
        }
        private void pctImagen47_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes4[1] + ".jpg";
            revisarContador(ruta);

            pctImagen47.ImageLocation = ruta;
            arregloRutas[46] = @"..\..\Imagenes\" + arregloImagenes4[1] + ".jpg";
            obtenerNombre(arregloRutas[46]);
            pctImagen47.Enabled = false;
        }
        private void pctImagen48_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes4[2] + ".jpg";
            revisarContador(ruta);

            pctImagen48.ImageLocation = ruta;
            arregloRutas[47] = @"..\..\Imagenes\" + arregloImagenes4[2] + ".jpg";
            obtenerNombre(arregloRutas[47]);
            pctImagen48.Enabled = false;
        }
        private void pctImagen49_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes4[3] + ".jpg";
            revisarContador(ruta);

            pctImagen49.ImageLocation = ruta;
            arregloRutas[48] = @"..\..\Imagenes\" + arregloImagenes4[3] + ".jpg";
            obtenerNombre(arregloRutas[48]);
            pctImagen49.Enabled = false;
        }
        private void pctImagen50_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes4[4] + ".jpg";
            revisarContador(ruta);

            pctImagen50.ImageLocation = ruta;
            arregloRutas[49] = @"..\..\Imagenes\" + arregloImagenes4[4] + ".jpg";
            obtenerNombre(arregloRutas[49]);
            pctImagen50.Enabled = false;
        }

        //Del 51 al 60
        private void pctImagen51_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes4[5] + ".jpg";
            revisarContador(ruta);

            pctImagen51.ImageLocation = ruta;
            arregloRutas[50] = @"..\..\Imagenes\" + arregloImagenes4[5] + ".jpg";
            obtenerNombre(arregloRutas[50]);
            pctImagen51.Enabled = false;
        }
        private void pctImagen52_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes4[6] + ".jpg";
            revisarContador(ruta);

            pctImagen52.ImageLocation = ruta;
            arregloRutas[51] = @"..\..\Imagenes\" + arregloImagenes4[6] + ".jpg";
            obtenerNombre(arregloRutas[51]);
            pctImagen52.Enabled = false;
        }
        private void pctImagen53_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes4[7] + ".jpg";
            revisarContador(ruta);

            pctImagen53.ImageLocation = ruta;
            arregloRutas[51] = @"..\..\Imagenes\" + arregloImagenes4[7] + ".jpg";
            obtenerNombre(arregloRutas[51]);
            pctImagen53.Enabled = false;
        }
        private void pctImagen54_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes4[8] + ".jpg";
            revisarContador(ruta);

            pctImagen54.ImageLocation = ruta;
            arregloRutas[53] = @"..\..\Imagenes\" + arregloImagenes4[8] + ".jpg";
            obtenerNombre(arregloRutas[53]);
            pctImagen54.Enabled = false;
        }
        private void pctImagen55_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes4[9] + ".jpg";
            revisarContador(ruta);

            pctImagen55.ImageLocation = ruta;
            arregloRutas[54] = @"..\..\Imagenes\" + arregloImagenes4[9] + ".jpg";
            obtenerNombre(arregloRutas[54]);
            pctImagen55.Enabled = false;
        }
        private void pctImagen56_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes4[10] + ".jpg";
            revisarContador(ruta);

            pctImagen56.ImageLocation = ruta;
            arregloRutas[55] = @"..\..\Imagenes\" + arregloImagenes4[10] + ".jpg";
            obtenerNombre(arregloRutas[55]);
            pctImagen56.Enabled = false;
        }
        private void pctImagen57_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes4[11] + ".jpg";
            revisarContador(ruta);

            pctImagen57.ImageLocation = ruta;
            arregloRutas[56] = @"..\..\Imagenes\" + arregloImagenes4[11] + ".jpg";
            obtenerNombre(arregloRutas[56]);
            pctImagen57.Enabled = false;
        }
        private void pctImagen58_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes4[12] + ".jpg";
            revisarContador(ruta);

            pctImagen58.ImageLocation = ruta;
            arregloRutas[57] = @"..\..\Imagenes\" + arregloImagenes4[12] + ".jpg";
            obtenerNombre(arregloRutas[57]);
            pctImagen58.Enabled = false;
        }
        private void pctImagen59_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes4[13] + ".jpg";
            revisarContador(ruta);

            pctImagen59.ImageLocation = ruta;
            arregloRutas[58] = @"..\..\Imagenes\" + arregloImagenes4[13] + ".jpg";
            obtenerNombre(arregloRutas[58]);
            pctImagen59.Enabled = false;
        }
        private void pctImagen60_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes4[14] + ".jpg";
            revisarContador(ruta);

            pctImagen60.ImageLocation = ruta;
            arregloRutas[59] = @"..\..\Imagenes\" + arregloImagenes4[14] + ".jpg";
            obtenerNombre(arregloRutas[59]);
            pctImagen60.Enabled = false;
        }

        //Del 61 al 70
        private void pctImagen61_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes5[0] + ".jpg";
            revisarContador(ruta);

            pctImagen61.ImageLocation = ruta;
            arregloRutas[59] = @"..\..\Imagenes\" + arregloImagenes5[0] + ".jpg";
            obtenerNombre(arregloRutas[59]);
            pctImagen61.Enabled = false;
        }
        private void pctImagen62_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes5[1] + ".jpg";
            revisarContador(ruta);

            pctImagen62.ImageLocation = ruta;
            arregloRutas[61] = @"..\..\Imagenes\" + arregloImagenes5[1] + ".jpg";
            obtenerNombre(arregloRutas[61]);
            pctImagen62.Enabled = false;
        }
        private void pctImagen63_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes5[2] + ".jpg";
            revisarContador(ruta);

            pctImagen63.ImageLocation = ruta;
            arregloRutas[62] = @"..\..\Imagenes\" + arregloImagenes5[2] + ".jpg";
            obtenerNombre(arregloRutas[62]);
            pctImagen63.Enabled = false;
        }
        private void pctImagen64_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes5[3] + ".jpg";
            revisarContador(ruta);

            pctImagen64.ImageLocation = ruta;
            arregloRutas[63] = @"..\..\Imagenes\" + arregloImagenes5[3] + ".jpg";
            obtenerNombre(arregloRutas[63]);
            pctImagen64.Enabled = false;
        }
        private void pctImagen65_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes5[4] + ".jpg";
            revisarContador(ruta);

            pctImagen65.ImageLocation = ruta;
            arregloRutas[64] = @"..\..\Imagenes\" + arregloImagenes5[4] + ".jpg";
            obtenerNombre(arregloRutas[64]);
            pctImagen65.Enabled = false;
        }
        private void pctImagen66_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes5[5] + ".jpg";
            revisarContador(ruta);

            pctImagen66.ImageLocation = ruta;
            arregloRutas[65] = @"..\..\Imagenes\" + arregloImagenes5[5] + ".jpg";
            obtenerNombre(arregloRutas[65]);
            pctImagen66.Enabled = false;
        }
        private void pctImagen67_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes5[6] + ".jpg";
            revisarContador(ruta);

            pctImagen67.ImageLocation = ruta;
            arregloRutas[66] = @"..\..\Imagenes\" + arregloImagenes5[6] + ".jpg";
            obtenerNombre(arregloRutas[66]);
            pctImagen67.Enabled = false;
        }
        private void pctImagen68_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes5[7] + ".jpg";
            revisarContador(ruta);

            pctImagen68.ImageLocation = ruta;
            arregloRutas[67] = @"..\..\Imagenes\" + arregloImagenes5[7] + ".jpg";
            obtenerNombre(arregloRutas[67]);
            pctImagen68.Enabled = false;
        }
        private void pctImagen69_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes5[8] + ".jpg";
            revisarContador(ruta);

            pctImagen69.ImageLocation = ruta;
            arregloRutas[68] = @"..\..\Imagenes\" + arregloImagenes5[8] + ".jpg";
            obtenerNombre(arregloRutas[68]);
            pctImagen69.Enabled = false;
        }
        private void pctImagen70_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes5[9] + ".jpg";
            revisarContador(ruta);

            pctImagen70.ImageLocation = ruta;
            arregloRutas[69] = @"..\..\Imagenes\" + arregloImagenes5[9] + ".jpg";
            obtenerNombre(arregloRutas[69]);
            pctImagen70.Enabled = false;
        }

        //Del 71 al 80
        private void pctImagen71_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes5[10] + ".jpg";
            revisarContador(ruta);

            pctImagen71.ImageLocation = ruta;
            arregloRutas[70] = @"..\..\Imagenes\" + arregloImagenes5[10] + ".jpg";
            obtenerNombre(arregloRutas[70]);
            pctImagen71.Enabled = false;
        }
        private void pctImagen72_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes5[11] + ".jpg";
            revisarContador(ruta);

            pctImagen72.ImageLocation = ruta;
            arregloRutas[71] = @"..\..\Imagenes\" + arregloImagenes5[11] + ".jpg";
            obtenerNombre(arregloRutas[71]);
            pctImagen72.Enabled = false;
        }
        private void pctImagen73_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes5[12] + ".jpg";
            revisarContador(ruta);

            pctImagen74.ImageLocation = ruta;
            arregloRutas[72] = @"..\..\Imagenes\" + arregloImagenes5[12] + ".jpg";
            obtenerNombre(arregloRutas[74]);
            pctImagen74.Enabled = false;
        }
        private void pctImagen74_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes5[13] + ".jpg";
            revisarContador(ruta);

            pctImagen74.ImageLocation = ruta;
            arregloRutas[73] = @"..\..\Imagenes\" + arregloImagenes5[13] + ".jpg";
            obtenerNombre(arregloRutas[73]);
            pctImagen74.Enabled = false;
        }
        private void pctImagen75_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes5[14] + ".jpg";
            revisarContador(ruta);

            pctImagen75.ImageLocation = ruta;
            arregloRutas[74] = @"..\..\Imagenes\" + arregloImagenes5[14] + ".jpg";
            obtenerNombre(arregloRutas[74]);
            pctImagen75.Enabled = false;
        }
        private void pctImagen76_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes6[0] + ".jpg";
            revisarContador(ruta);

            pctImagen76.ImageLocation = ruta;
            arregloRutas[75] = @"..\..\Imagenes\" + arregloImagenes6[0] + ".jpg";
            obtenerNombre(arregloRutas[75]);
            pctImagen76.Enabled = false;
        }
        private void pctImagen77_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes6[1] + ".jpg";
            revisarContador(ruta);

            pctImagen77.ImageLocation = ruta;
            arregloRutas[76] = @"..\..\Imagenes\" + arregloImagenes6[1] + ".jpg";
            obtenerNombre(arregloRutas[76]);
            pctImagen77.Enabled = false;
        }
        private void pctImagen78_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes6[2] + ".jpg";
            revisarContador(ruta);

            pctImagen78.ImageLocation = ruta;
            arregloRutas[77] = @"..\..\Imagenes\" + arregloImagenes6[2] + ".jpg";
            obtenerNombre(arregloRutas[77]);
            pctImagen78.Enabled = false;
        }
        private void pctImagen79_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes6[3] + ".jpg";
            revisarContador(ruta);

            pctImagen79.ImageLocation = ruta;
            arregloRutas[78] = @"..\..\Imagenes\" + arregloImagenes6[3] + ".jpg";
            obtenerNombre(arregloRutas[78]);
            pctImagen79.Enabled = false;
        }
        private void pctImagen80_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes6[4] + ".jpg";
            revisarContador(ruta);

            pctImagen80.ImageLocation = ruta;
            arregloRutas[79] = @"..\..\Imagenes\" + arregloImagenes6[4] + ".jpg";
            obtenerNombre(arregloRutas[79]);
            pctImagen80.Enabled = false;
        }

        //Del 81 al 90
        private void pctImagen81_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes6[5] + ".jpg";
            revisarContador(ruta);

            pctImagen81.ImageLocation = ruta;
            arregloRutas[80] = @"..\..\Imagenes\" + arregloImagenes6[5] + ".jpg";
            obtenerNombre(arregloRutas[80]);
            pctImagen81.Enabled = false;
        }
        private void pctImagen82_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes6[6] + ".jpg";
            revisarContador(ruta);

            pctImagen82.ImageLocation = ruta;
            arregloRutas[81] = @"..\..\Imagenes\" + arregloImagenes6[6] + ".jpg";
            obtenerNombre(arregloRutas[81]);
            pctImagen82.Enabled = false;
        }
        private void pctImagen83_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes6[7] + ".jpg";
            revisarContador(ruta);

            pctImagen83.ImageLocation = ruta;
            arregloRutas[82] = @"..\..\Imagenes\" + arregloImagenes6[7] + ".jpg";
            obtenerNombre(arregloRutas[82]);
            pctImagen83.Enabled = false;
        }
        private void pctImagen84_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes6[8] + ".jpg";
            revisarContador(ruta);

            pctImagen84.ImageLocation = ruta;
            arregloRutas[83] = @"..\..\Imagenes\" + arregloImagenes6[8] + ".jpg";
            obtenerNombre(arregloRutas[83]);
            pctImagen84.Enabled = false;
        }
        private void pctImagen85_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes6[9] + ".jpg";
            revisarContador(ruta);

            pctImagen85.ImageLocation = ruta;
            arregloRutas[84] = @"..\..\Imagenes\" + arregloImagenes6[9] + ".jpg";
            obtenerNombre(arregloRutas[84]);
            pctImagen85.Enabled = false;
        }
        private void pctImagen86_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes6[10] + ".jpg";
            revisarContador(ruta);

            pctImagen86.ImageLocation = ruta;
            arregloRutas[85] = @"..\..\Imagenes\" + arregloImagenes6[10] + ".jpg";
            obtenerNombre(arregloRutas[85]);
            pctImagen86.Enabled = false;
        }
        private void pctImagen87_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes6[11] + ".jpg";
            revisarContador(ruta);

            pctImagen87.ImageLocation = ruta;
            arregloRutas[86] = @"..\..\Imagenes\" + arregloImagenes6[11] + ".jpg";
            obtenerNombre(arregloRutas[86]);
            pctImagen87.Enabled = false;
        }
        private void pctImagen88_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes6[12] + ".jpg";
            revisarContador(ruta);

            pctImagen88.ImageLocation = ruta;
            arregloRutas[87] = @"..\..\Imagenes\" + arregloImagenes6[12] + ".jpg";
            obtenerNombre(arregloRutas[87]);
            pctImagen88.Enabled = false;
        }
        private void pctImagen89_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes6[13] + ".jpg";
            revisarContador(ruta);

            pctImagen89.ImageLocation = ruta;
            arregloRutas[88] = @"..\..\Imagenes\" + arregloImagenes6[13] + ".jpg";
            obtenerNombre(arregloRutas[88]);
            pctImagen89.Enabled = false;
        }
        private void pctImagen90_Click(object sender, EventArgs e)
        {
            cerrarRapido();
            string ruta = @"..\..\Imagenes\" + arregloImagenes6[14] + ".jpg";
            revisarContador(ruta);

            pctImagen90.ImageLocation = ruta;
            arregloRutas[89] = @"..\..\Imagenes\" + arregloImagenes6[14] + ".jpg";
            obtenerNombre(arregloRutas[89]);
            pctImagen90.Enabled = false;
        }

        

        

 





       
        


      
    }
}