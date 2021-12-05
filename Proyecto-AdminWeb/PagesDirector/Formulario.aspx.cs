﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_AdminWeb.PagesDirector
{
    public partial class Formulario : System.Web.UI.Page
    {
        ConexionDB db = new ConexionDB();

        string evaluacion;
        string componente;
        string eje;
        static int nivel;
        int obligatorio;
        string cantidads;
        int cantidad;

        static string id1;
        static string id2;
        static string id3;
        static string id4;
        static string id5;
        static string id6;
        static string id7;
        static string id8;
        static string id9;
        static string id10;

        static int iid1;
        static int iid2;
        static int iid3;
        static int iid4;
        static int iid5;
        static int iid6;
        static int iid7;
        static int iid8;
        static int iid9;
        static int iid10;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Nuevo_Click(object sender, EventArgs e)
        {
            if (Panel2.Visible == false & Panel3.Visible == false & Panel4.Visible == false & Panel5.Visible == false & Panel6.Visible == false & Panel7.Visible == false & Panel8.Visible == false & Panel9.Visible == false)
            {
                Panel2.Visible = true;
            }
            else if (Panel3.Visible == false & Panel4.Visible == false & Panel5.Visible == false & Panel6.Visible == false & Panel7.Visible == false & Panel8.Visible == false & Panel9.Visible == false)
            {
                Panel3.Visible = true;
            }
            else if (Panel4.Visible == false & Panel5.Visible == false & Panel6.Visible == false & Panel7.Visible == false & Panel8.Visible == false & Panel9.Visible == false)
            {
                Panel4.Visible = true;
            }
            else if (Panel5.Visible == false & Panel6.Visible == false & Panel7.Visible == false & Panel8.Visible == false & Panel9.Visible == false)
            {
                Panel5.Visible = true;
            }
            else if (Panel6.Visible == false & Panel7.Visible == false & Panel8.Visible == false & Panel9.Visible == false)
            {
                Panel6.Visible = true;
            }
            else if (Panel7.Visible == false & Panel8.Visible == false & Panel9.Visible == false)
            {
                Panel7.Visible = true;
            }
            else if (Panel8.Visible == false & Panel9.Visible == false)
            {
                Panel8.Visible = true;
            }
            else if (Panel9.Visible == false)
            {
                Panel9.Visible = true;
            }
        }

        #region NIVELES
        public void btnIncipiente_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";

            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            Panel7.Visible = false;
            Panel8.Visible = false;
            Panel9.Visible = false;
            Panel10.Visible = false;

            evaluacion = Request.QueryString["valor1"];
            componente = Request.QueryString["valor2"];
            eje = Request.QueryString["valor3"];

            #region Nileves
            if (componente == "1" & eje == "1") {
                nivel = 1;
            }
            if (componente == "1" & eje == "2")
            {
                nivel = 6;
            }
            if (componente == "1" & eje == "3")
            {
                nivel = 11;
            }
            if (componente == "1" & eje == "4")
            {
                nivel = 16;
            }
            if (componente == "2" & eje == "5")
            {
                nivel = 21;
            }
            if (componente == "2" & eje == "6")
            {
                nivel = 26;
            }
            if (componente == "2" & eje == "7")
            {
                nivel = 31;
            }
            if (componente == "2" & eje == "8")
            {
                nivel = 36;
            }
            if (componente == "3" & eje == "9")
            {
                nivel = 41;
            }
            if (componente == "3" & eje == "10")
            {
                nivel = 46;
            }
            if (componente == "3" & eje == "11")
            {
                nivel = 51;
            }
            if (componente == "3" & eje == "12")
            {
                nivel = 56;
            }
            if (componente == "4" & eje == "13")
            {
                nivel = 61;
            }
            if (componente == "4" & eje == "14")
            {
                nivel = 66;
            }
            if (componente == "4" & eje == "15")
            {
                nivel = 71;
            }
            if (componente == "4" & eje == "16")
            {
                nivel = 76;
            }
            if (componente == "5" & eje == "17")
            {
                nivel = 81;
            }
            if (componente == "5" & eje == "18")
            {
                nivel = 86;
            }
            if (componente == "5" & eje == "19")
            {
                nivel = 91;
            }
            if (componente == "5" & eje == "20")
            {
                nivel = 96;
            }
            #endregion

            cantidads = db.obtenerCantidadPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["CANTIDAD"].ToString();
            cantidad = Int32.Parse(cantidads);

            #region ID
            if (cantidad == 1)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
            }
            else if (cantidad == 2)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
            }
            else if (cantidad == 3)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
            }
            else if (cantidad == 4)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
            }
            else if (cantidad == 5)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
            }
            else if (cantidad == 6)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
            }
            else if (cantidad == 7)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
            }
            else if (cantidad == 8)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
                id8 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["ID"].ToString();
                iid8 = Int32.Parse(id8);
            }
            else if (cantidad == 9)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
                id8 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["ID"].ToString();
                iid8 = Int32.Parse(id8);
                id9 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["ID"].ToString();
                iid9 = Int32.Parse(id9);
            }
            else if (cantidad == 10)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
                id8 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["ID"].ToString();
                iid8 = Int32.Parse(id8);
                id9 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["ID"].ToString();
                iid9 = Int32.Parse(id9);
                id10 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[9]["ID"].ToString();
                iid10 = Int32.Parse(id10);
            }
            #endregion

            #region Paneles
            if (cantidad == 0)
            {
                Panel1.Visible = true;
            }
            else if (cantidad == 1)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }
            }
            else if (cantidad == 2)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }
            }
            else if (cantidad == 3)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }
            }
            else if (cantidad == 4)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }
            }
            else if (cantidad == 5)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }
            }
            else if (cantidad == 6)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }
            }
            else if (cantidad == 7)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();
                TextBox7.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox7.Checked = true;
                }
            }
            else if (cantidad == 8)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();
                TextBox7.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["DESCRIPCION"].ToString();
                TextBox8.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox7.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox8.Checked = true;
                }
            }
            else if (cantidad == 9)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;
                Panel10.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();
                TextBox7.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["DESCRIPCION"].ToString();
                TextBox8.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["DESCRIPCION"].ToString();
                TextBox9.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox7.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox8.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox9.Checked = true;
                }
            }
            #endregion
        }

        public void btnNovato_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";

            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            Panel7.Visible = false;
            Panel8.Visible = false;
            Panel9.Visible = false;
            Panel10.Visible = false;

            evaluacion = Request.QueryString["valor1"];
            componente = Request.QueryString["valor2"];
            eje = Request.QueryString["valor3"];

            #region Nileves
            if (componente == "1" & eje == "1")
            {
                nivel = 2;
            }
            if (componente == "1" & eje == "2")
            {
                nivel = 7;
            }
            if (componente == "1" & eje == "3")
            {
                nivel = 12;
            }
            if (componente == "1" & eje == "4")
            {
                nivel = 17;
            }
            if (componente == "2" & eje == "5")
            {
                nivel = 22;
            }
            if (componente == "2" & eje == "6")
            {
                nivel = 27;
            }
            if (componente == "2" & eje == "7")
            {
                nivel = 32;
            }
            if (componente == "2" & eje == "8")
            {
                nivel = 37;
            }
            if (componente == "3" & eje == "9")
            {
                nivel = 42;
            }
            if (componente == "3" & eje == "10")
            {
                nivel = 47;
            }
            if (componente == "3" & eje == "11")
            {
                nivel = 52;
            }
            if (componente == "3" & eje == "12")
            {
                nivel = 57;
            }
            if (componente == "4" & eje == "13")
            {
                nivel = 62;
            }
            if (componente == "4" & eje == "14")
            {
                nivel = 67;
            }
            if (componente == "4" & eje == "15")
            {
                nivel = 72;
            }
            if (componente == "4" & eje == "16")
            {
                nivel = 77;
            }
            if (componente == "5" & eje == "17")
            {
                nivel = 82;
            }
            if (componente == "5" & eje == "18")
            {
                nivel = 87;
            }
            if (componente == "5" & eje == "19")
            {
                nivel = 92;
            }
            if (componente == "5" & eje == "20")
            {
                nivel = 97;
            }
            #endregion

            cantidads = db.obtenerCantidadPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["CANTIDAD"].ToString();
            cantidad = Int32.Parse(cantidads);

            #region ID
            if (cantidad == 1)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
            }
            else if (cantidad == 2)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
            }
            else if (cantidad == 3)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
            }
            else if (cantidad == 4)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
            }
            else if (cantidad == 5)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
            }
            else if (cantidad == 6)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
            }
            else if (cantidad == 7)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
            }
            else if (cantidad == 8)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
                id8 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["ID"].ToString();
                iid8 = Int32.Parse(id8);
            }
            else if (cantidad == 9)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
                id8 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["ID"].ToString();
                iid8 = Int32.Parse(id8);
                id9 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["ID"].ToString();
                iid9 = Int32.Parse(id9);
            }
            else if (cantidad == 10)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
                id8 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["ID"].ToString();
                iid8 = Int32.Parse(id8);
                id9 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["ID"].ToString();
                iid9 = Int32.Parse(id9);
                id10 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[9]["ID"].ToString();
                iid10 = Int32.Parse(id10);
            }
            #endregion

            #region Paneles
            if (cantidad == 0)
            {
                Panel1.Visible = true;
            }
            else if (cantidad == 1)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }
            }
            else if (cantidad == 2)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }
            }
            else if (cantidad == 3)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }
            }
            else if (cantidad == 4)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }
            }
            else if (cantidad == 5)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }
            }
            else if (cantidad == 6)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }
            }
            else if (cantidad == 7)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();
                TextBox7.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox7.Checked = true;
                }
            }
            else if (cantidad == 8)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();
                TextBox7.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["DESCRIPCION"].ToString();
                TextBox8.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox7.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox8.Checked = true;
                }
            }
            else if (cantidad == 9)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;
                Panel10.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();
                TextBox7.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["DESCRIPCION"].ToString();
                TextBox8.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["DESCRIPCION"].ToString();
                TextBox9.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox7.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox8.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox9.Checked = true;
                }
            }
            #endregion
        }

        public void btnCompetente_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";

            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            Panel7.Visible = false;
            Panel8.Visible = false;
            Panel9.Visible = false;
            Panel10.Visible = false;

            evaluacion = Request.QueryString["valor1"];
            componente = Request.QueryString["valor2"];
            eje = Request.QueryString["valor3"];

            #region Nileves
            if (componente == "1" & eje == "1")
            {
                nivel = 3;
            }
            if (componente == "1" & eje == "2")
            {
                nivel = 8;
            }
            if (componente == "1" & eje == "3")
            {
                nivel = 13;
            }
            if (componente == "1" & eje == "4")
            {
                nivel = 18;
            }
            if (componente == "2" & eje == "5")
            {
                nivel = 23;
            }
            if (componente == "2" & eje == "6")
            {
                nivel = 28;
            }
            if (componente == "2" & eje == "7")
            {
                nivel = 33;
            }
            if (componente == "2" & eje == "8")
            {
                nivel = 38;
            }
            if (componente == "3" & eje == "9")
            {
                nivel = 43;
            }
            if (componente == "3" & eje == "10")
            {
                nivel = 48;
            }
            if (componente == "3" & eje == "11")
            {
                nivel = 53;
            }
            if (componente == "3" & eje == "12")
            {
                nivel = 58;
            }
            if (componente == "4" & eje == "13")
            {
                nivel = 63;
            }
            if (componente == "4" & eje == "14")
            {
                nivel = 68;
            }
            if (componente == "4" & eje == "15")
            {
                nivel = 73;
            }
            if (componente == "4" & eje == "16")
            {
                nivel = 78;
            }
            if (componente == "5" & eje == "17")
            {
                nivel = 83;
            }
            if (componente == "5" & eje == "18")
            {
                nivel = 88;
            }
            if (componente == "5" & eje == "19")
            {
                nivel = 93;
            }
            if (componente == "5" & eje == "20")
            {
                nivel = 98;
            }
            #endregion

            cantidads = db.obtenerCantidadPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["CANTIDAD"].ToString();
            cantidad = Int32.Parse(cantidads);

            #region ID
            if (cantidad == 1)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
            }
            else if (cantidad == 2)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
            }
            else if (cantidad == 3)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
            }
            else if (cantidad == 4)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
            }
            else if (cantidad == 5)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
            }
            else if (cantidad == 6)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
            }
            else if (cantidad == 7)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
            }
            else if (cantidad == 8)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
                id8 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["ID"].ToString();
                iid8 = Int32.Parse(id8);
            }
            else if (cantidad == 9)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
                id8 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["ID"].ToString();
                iid8 = Int32.Parse(id8);
                id9 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["ID"].ToString();
                iid9 = Int32.Parse(id9);
            }
            else if (cantidad == 10)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
                id8 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["ID"].ToString();
                iid8 = Int32.Parse(id8);
                id9 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["ID"].ToString();
                iid9 = Int32.Parse(id9);
                id10 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[9]["ID"].ToString();
                iid10 = Int32.Parse(id10);
            }
            #endregion

            #region Paneles
            if (cantidad == 0)
            {
                Panel1.Visible = true;
            }
            else if (cantidad == 1)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }
            }
            else if (cantidad == 2)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }
            }
            else if (cantidad == 3)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }
            }
            else if (cantidad == 4)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }
            }
            else if (cantidad == 5)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }
            }
            else if (cantidad == 6)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }
            }
            else if (cantidad == 7)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();
                TextBox7.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox7.Checked = true;
                }
            }
            else if (cantidad == 8)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();
                TextBox7.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["DESCRIPCION"].ToString();
                TextBox8.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox7.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox8.Checked = true;
                }
            }
            else if (cantidad == 9)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;
                Panel10.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();
                TextBox7.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["DESCRIPCION"].ToString();
                TextBox8.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["DESCRIPCION"].ToString();
                TextBox9.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox7.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox8.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox9.Checked = true;
                }
            }
            #endregion
        }

        public void btnDiestro_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";

            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            Panel7.Visible = false;
            Panel8.Visible = false;
            Panel9.Visible = false;
            Panel10.Visible = false;

            evaluacion = Request.QueryString["valor1"];
            componente = Request.QueryString["valor2"];
            eje = Request.QueryString["valor3"];

            #region Nileves
            if (componente == "1" & eje == "1")
            {
                nivel = 4;
            }
            if (componente == "1" & eje == "2")
            {
                nivel = 9;
            }
            if (componente == "1" & eje == "3")
            {
                nivel = 14;
            }
            if (componente == "1" & eje == "4")
            {
                nivel = 19;
            }
            if (componente == "2" & eje == "5")
            {
                nivel = 24;
            }
            if (componente == "2" & eje == "6")
            {
                nivel = 29;
            }
            if (componente == "2" & eje == "7")
            {
                nivel = 34;
            }
            if (componente == "2" & eje == "8")
            {
                nivel = 39;
            }
            if (componente == "3" & eje == "9")
            {
                nivel = 44;
            }
            if (componente == "3" & eje == "10")
            {
                nivel = 49;
            }
            if (componente == "3" & eje == "11")
            {
                nivel = 54;
            }
            if (componente == "3" & eje == "12")
            {
                nivel = 59;
            }
            if (componente == "4" & eje == "13")
            {
                nivel = 64;
            }
            if (componente == "4" & eje == "14")
            {
                nivel = 69;
            }
            if (componente == "4" & eje == "15")
            {
                nivel = 74;
            }
            if (componente == "4" & eje == "16")
            {
                nivel = 79;
            }
            if (componente == "5" & eje == "17")
            {
                nivel = 84;
            }
            if (componente == "5" & eje == "18")
            {
                nivel = 89;
            }
            if (componente == "5" & eje == "19")
            {
                nivel = 94;
            }
            if (componente == "5" & eje == "20")
            {
                nivel = 99;
            }
            #endregion

            cantidads = db.obtenerCantidadPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["CANTIDAD"].ToString();
            cantidad = Int32.Parse(cantidads);

            #region ID
            if (cantidad == 1)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
            }
            else if (cantidad == 2)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
            }
            else if (cantidad == 3)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
            }
            else if (cantidad == 4)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
            }
            else if (cantidad == 5)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
            }
            else if (cantidad == 6)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
            }
            else if (cantidad == 7)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
            }
            else if (cantidad == 8)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
                id8 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["ID"].ToString();
                iid8 = Int32.Parse(id8);
            }
            else if (cantidad == 9)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
                id8 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["ID"].ToString();
                iid8 = Int32.Parse(id8);
                id9 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["ID"].ToString();
                iid9 = Int32.Parse(id9);
            }
            else if (cantidad == 10)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
                id8 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["ID"].ToString();
                iid8 = Int32.Parse(id8);
                id9 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["ID"].ToString();
                iid9 = Int32.Parse(id9);
                id10 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[9]["ID"].ToString();
                iid10 = Int32.Parse(id10);
            }
            #endregion

            #region Paneles
            if (cantidad == 0)
            {
                Panel1.Visible = true;
            }
            else if (cantidad == 1)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }
            }
            else if (cantidad == 2)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }
            }
            else if (cantidad == 3)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }
            }
            else if (cantidad == 4)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }
            }
            else if (cantidad == 5)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }
            }
            else if (cantidad == 6)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }
            }
            else if (cantidad == 7)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();
                TextBox7.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox7.Checked = true;
                }
            }
            else if (cantidad == 8)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();
                TextBox7.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["DESCRIPCION"].ToString();
                TextBox8.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox7.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox8.Checked = true;
                }
            }
            else if (cantidad == 9)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;
                Panel10.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();
                TextBox7.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["DESCRIPCION"].ToString();
                TextBox8.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["DESCRIPCION"].ToString();
                TextBox9.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox7.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox8.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox9.Checked = true;
                }
            }
            #endregion
        }

        public void btnExperto_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";

            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            Panel7.Visible = false;
            Panel8.Visible = false;
            Panel9.Visible = false;
            Panel10.Visible = false;

            evaluacion = Request.QueryString["valor1"];
            componente = Request.QueryString["valor2"];
            eje = Request.QueryString["valor3"];

            #region Nileves
            if (componente == "1" & eje == "1")
            {
                nivel = 5;
            }
            if (componente == "1" & eje == "2")
            {
                nivel = 10;
            }
            if (componente == "1" & eje == "3")
            {
                nivel = 15;
            }
            if (componente == "1" & eje == "4")
            {
                nivel = 20;
            }
            if (componente == "2" & eje == "5")
            {
                nivel = 25;
            }
            if (componente == "2" & eje == "6")
            {
                nivel = 30;
            }
            if (componente == "2" & eje == "7")
            {
                nivel = 35;
            }
            if (componente == "2" & eje == "8")
            {
                nivel = 40;
            }
            if (componente == "3" & eje == "9")
            {
                nivel = 45;
            }
            if (componente == "3" & eje == "10")
            {
                nivel = 50;
            }
            if (componente == "3" & eje == "11")
            {
                nivel = 55;
            }
            if (componente == "3" & eje == "12")
            {
                nivel = 60;
            }
            if (componente == "4" & eje == "13")
            {
                nivel = 65;
            }
            if (componente == "4" & eje == "14")
            {
                nivel = 70;
            }
            if (componente == "4" & eje == "15")
            {
                nivel = 75;
            }
            if (componente == "4" & eje == "16")
            {
                nivel = 80;
            }
            if (componente == "5" & eje == "17")
            {
                nivel = 85;
            }
            if (componente == "5" & eje == "18")
            {
                nivel = 90;
            }
            if (componente == "5" & eje == "19")
            {
                nivel = 95;
            }
            if (componente == "5" & eje == "20")
            {
                nivel = 100;
            }
            #endregion

            cantidads = db.obtenerCantidadPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["CANTIDAD"].ToString();
            cantidad = Int32.Parse(cantidads);

            #region ID
            if (cantidad == 1)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
            }
            else if (cantidad == 2)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
            }
            else if (cantidad == 3)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
            }
            else if (cantidad == 4)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
            }
            else if (cantidad == 5)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
            }
            else if (cantidad == 6)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
            }
            else if (cantidad == 7)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
            }
            else if (cantidad == 8)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
                id8 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["ID"].ToString();
                iid8 = Int32.Parse(id8);
            }
            else if (cantidad == 9)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
                id8 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["ID"].ToString();
                iid8 = Int32.Parse(id8);
                id9 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["ID"].ToString();
                iid9 = Int32.Parse(id9);
            }
            else if (cantidad == 10)
            {
                id1 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["ID"].ToString();
                iid1 = Int32.Parse(id1);
                id2 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["ID"].ToString();
                iid2 = Int32.Parse(id2);
                id3 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["ID"].ToString();
                iid3 = Int32.Parse(id3);
                id4 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["ID"].ToString();
                iid4 = Int32.Parse(id4);
                id5 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["ID"].ToString();
                iid5 = Int32.Parse(id5);
                id6 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["ID"].ToString();
                iid6 = Int32.Parse(id6);
                id7 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["ID"].ToString();
                iid7 = Int32.Parse(id7);
                id8 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["ID"].ToString();
                iid8 = Int32.Parse(id8);
                id9 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["ID"].ToString();
                iid9 = Int32.Parse(id9);
                id10 = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[9]["ID"].ToString();
                iid10 = Int32.Parse(id10);
            }
            #endregion

            #region Paneles
            if (cantidad == 0)
            {
                Panel1.Visible = true;
            }
            else if (cantidad == 1)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }
            }
            else if (cantidad == 2)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }
            }
            else if (cantidad == 3)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }
            }
            else if (cantidad == 4)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }
            }
            else if (cantidad == 5)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }
            }
            else if (cantidad == 6)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }
            }
            else if (cantidad == 7)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();
                TextBox7.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox7.Checked = true;
                }
            }
            else if (cantidad == 8)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();
                TextBox7.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["DESCRIPCION"].ToString();
                TextBox8.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox7.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox8.Checked = true;
                }
            }
            else if (cantidad == 9)
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;
                Panel10.Visible = true;

                TextBox1.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["DESCRIPCION"].ToString();
                TextBox2.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["DESCRIPCION"].ToString();
                TextBox3.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["DESCRIPCION"].ToString();
                TextBox4.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["DESCRIPCION"].ToString();
                TextBox5.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["DESCRIPCION"].ToString();
                TextBox6.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["DESCRIPCION"].ToString();
                TextBox7.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["DESCRIPCION"].ToString();
                TextBox8.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["DESCRIPCION"].ToString();
                TextBox9.Text = db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["DESCRIPCION"].ToString();

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[0]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox1.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[1]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox2.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[2]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox3.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[3]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox4.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[4]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox5.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[5]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox6.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[6]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox7.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[7]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox8.Checked = true;
                }

                if (db.obtenerPreguntas(evaluacion, Int32.Parse(componente), Int32.Parse(eje), nivel).Rows[8]["OBLIGATORIO"].ToString() == "1")
                {
                    CheckBox9.Checked = true;
                }
            }
            #endregion
        }
        #endregion

        #region ACEPTAR
        protected void Aprobar1(object sender, EventArgs e)
        {
            evaluacion = Request.QueryString["valor1"];
            componente = Request.QueryString["valor2"];
            eje = Request.QueryString["valor3"];

            if (CheckBox1.Checked)
            {
                obligatorio = 1;
                db.registrarPreguntas(TextBox1.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
            else
            {
                obligatorio = 0;
                db.registrarPreguntas(TextBox1.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }

        }
        protected void Aprobar2(object sender, EventArgs e)
        {
            evaluacion = Request.QueryString["valor1"];
            componente = Request.QueryString["valor2"];
            eje = Request.QueryString["valor3"];

            if (CheckBox2.Checked)
            {
                obligatorio = 1;
                db.registrarPreguntas(TextBox2.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
            else
            {
                obligatorio = 0;
                db.registrarPreguntas(TextBox2.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
        }
        protected void Aprobar3(object sender, EventArgs e)
        {
            evaluacion = Request.QueryString["valor1"];
            componente = Request.QueryString["valor2"];
            eje = Request.QueryString["valor3"];

            if (CheckBox3.Checked)
            {
                obligatorio = 1;
                db.registrarPreguntas(TextBox3.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
            else
            {
                obligatorio = 0;
                db.registrarPreguntas(TextBox3.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
        }
        protected void Aprobar4(object sender, EventArgs e)
        {
            evaluacion = Request.QueryString["valor1"];
            componente = Request.QueryString["valor2"];
            eje = Request.QueryString["valor3"];

            if (CheckBox4.Checked)
            {
                obligatorio = 1;
                db.registrarPreguntas(TextBox4.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
            else
            {
                obligatorio = 0;
                db.registrarPreguntas(TextBox4.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
        }
        protected void Aprobar5(object sender, EventArgs e)
        {
            evaluacion = Request.QueryString["valor1"];
            componente = Request.QueryString["valor2"];
            eje = Request.QueryString["valor3"];

            if (CheckBox5.Checked)
            {
                obligatorio = 1;
                db.registrarPreguntas(TextBox5.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
            else
            {
                obligatorio = 0;
                db.registrarPreguntas(TextBox5.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
        }
        protected void Aprobar6(object sender, EventArgs e)
        {
            evaluacion = Request.QueryString["valor1"];
            componente = Request.QueryString["valor2"];
            eje = Request.QueryString["valor3"];

            if (CheckBox6.Checked)
            {
                obligatorio = 1;
                db.registrarPreguntas(TextBox6.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
            else
            {
                obligatorio = 0;
                db.registrarPreguntas(TextBox6.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
        }
        protected void Aprobar7(object sender, EventArgs e)
        {
            evaluacion = Request.QueryString["valor1"];
            componente = Request.QueryString["valor2"];
            eje = Request.QueryString["valor3"];

            if (CheckBox7.Checked)
            {
                obligatorio = 1;
                db.registrarPreguntas(TextBox7.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
            else
            {
                obligatorio = 0;
                db.registrarPreguntas(TextBox7.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
        }
        protected void Aprobar8(object sender, EventArgs e)
        {
            evaluacion = Request.QueryString["valor1"];
            componente = Request.QueryString["valor2"];
            eje = Request.QueryString["valor3"];

            if (CheckBox8.Checked)
            {
                obligatorio = 1;
                db.registrarPreguntas(TextBox8.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
            else
            {
                obligatorio = 0;
                db.registrarPreguntas(TextBox8.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
        }
        protected void Aprobar9(object sender, EventArgs e)
        {
            evaluacion = Request.QueryString["valor1"];
            componente = Request.QueryString["valor2"];
            eje = Request.QueryString["valor3"];

            if (CheckBox9.Checked)
            {
                obligatorio = 1;
                db.registrarPreguntas(TextBox9.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
            else
            {
                obligatorio = 0;
                db.registrarPreguntas(TextBox9.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
        }
        protected void Aprobar10(object sender, EventArgs e)
        {
            evaluacion = Request.QueryString["valor1"];
            componente = Request.QueryString["valor2"];
            eje = Request.QueryString["valor3"];

            if (CheckBox10.Checked)
            {
                obligatorio = 1;
                db.registrarPreguntas(TextBox10.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
            else
            {
                obligatorio = 0;
                db.registrarPreguntas(TextBox10.Text, obligatorio, evaluacion, nivel, Int32.Parse(eje), Int32.Parse(componente));
            }
        }
        #endregion

        #region MODIFICAR
        protected void Modificar1(object sender, EventArgs e)
        {
            db.actualizarPreguntas(TextBox1.Text, iid1);
        }
        protected void Modificar2(object sender, EventArgs e)
        {
            db.actualizarPreguntas(TextBox2.Text, iid2);
        }
        protected void Modificar3(object sender, EventArgs e)
        {
            db.actualizarPreguntas(TextBox3.Text, iid3);
        }
        protected void Modificar4(object sender, EventArgs e)
        {
            db.actualizarPreguntas(TextBox4.Text, iid4);
        }
        protected void Modificar5(object sender, EventArgs e)
        {
            db.actualizarPreguntas(TextBox5.Text, iid5);
        }
        protected void Modificar6(object sender, EventArgs e)
        {
            db.actualizarPreguntas(TextBox6.Text, iid6);
        }
        protected void Modificar7(object sender, EventArgs e)
        {
            db.actualizarPreguntas(TextBox7.Text, iid7);
        }
        protected void Modificar8(object sender, EventArgs e)
        {
            db.actualizarPreguntas(TextBox8.Text, iid8);
        }
        protected void Modificar9(object sender, EventArgs e)
        {
            db.actualizarPreguntas(TextBox9.Text, iid9);
        }
        protected void Modificar10(object sender, EventArgs e)
        {
            db.actualizarPreguntas(TextBox10.Text, iid10);
        }
        #endregion

    }
}