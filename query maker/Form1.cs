﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace query_maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void resultado_TextChanged()
        {
            string vtaconvenio = " where NumActoVenta = " + tbNumActoVenta.Text  + " and CodIdVentaConvenio =" + tbCodIdVentaConvenio.Text + " and CorrPrestacion =" + tbCorrPrestacion.Text + ";" + "\n" + "\n";
            string bonoprestacion = " where NumActoVenta = " + tbNumActoVenta.Text + " and CodIdVentaConvenio =" + tbCodIdVentaConvenio.Text + " and FolioBono = " + tbFolioBono.Text + " and CorrPrestacion =" + tbCorrPrestacion.Text + ";";
            switch (prestaciones.SelectedIndex)
            {
                case 0:
                    this.resultado.Text = "update trprestacionventaconvenio set  CodIdPrestacionCertificador = 13893, CodPrestacionCertificador = '0306691',CodIdPrestacionHomologo = 47073,CodItemFinanciador = 0 " + vtaconvenio +
                "update trbonoprestaciones set  CodIdPrestacionCertificador = 13893" + bonoprestacion ;
                    break;

                case 1:
                    this.resultado.Text = "update trprestacionventaconvenio set  CodIdPrestacionCertificador = 13899, CodPrestacionCertificador = '0306692',CodIdPrestacionHomologo = 47088,CodItemFinanciador = 0" +vtaconvenio +
                "update trbonoprestaciones set  CodIdPrestacionCertificador = 13899"+ bonoprestacion;
                    break;

                case 2:
                    this.resultado.Text = "update trprestacionventaconvenio set  CodIdPrestacionCertificador = 13956, CodPrestacionCertificador = '0308646',CodIdPrestacionHomologo = 47124,CodItemFinanciador = 0" + vtaconvenio +
                "update trbonoprestaciones set  CodIdPrestacionCertificador = 13956" + bonoprestacion;
                    break;

                case 3:
                    this.resultado.Text = "update trprestacionventaconvenio set  CodIdPrestacionCertificador = 16720, CodPrestacionCertificador = '0305691',CodIdPrestacionHomologo = 59224,CodItemFinanciador = 0" + vtaconvenio +
                "update trbonoprestaciones set  CodIdPrestacionCertificador = 16720" + bonoprestacion;
                    break;

                case 4:
                    this.resultado.Text = "update trprestacionventaconvenio set  CodIdPrestacionCertificador = 16726, CodPrestacionCertificador = '0305692',CodIdPrestacionHomologo = 59227,CodItemFinanciador = 0" + vtaconvenio +
                "update trbonoprestaciones set  CodIdPrestacionCertificador = 16726" + bonoprestacion;
                    break;

                default:
                    MessageBox.Show("Selecciona una Prestacion");
                    break;
            }

        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            resultado_TextChanged();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void resultado1_TextChanged()
        {
            if(rbFin.Checked)
            {
                this.resultado1.Text = "UPDATE trseguimiento SET AtrEstadoConciliacion =2 WHERE FolioBono = "+tbFolioBono1.Text + " and CodIdVentaConvenio =" + tbCodIdVentaConvenio1.Text + " and CodEntidad= " + cbEntidad.Text + " and AtrEntidadConciliar= 1;";
            }
            else if (rbCia.Checked)
            {
                this.resultado1.Text = "UPDATE trseguimiento SET AtrEstadoConciliacion =2 WHERE FolioBono = " + tbFolioBono1.Text + " and CodIdVentaConvenio =" + tbCodIdVentaConvenio1.Text + " and CodEntidad= " + cbEntidad.Text + " and AtrEntidadConciliar= 3;";
            }
            
        }

        private void btgenerar1_Click(object sender, EventArgs e)
        {
            resultado1_TextChanged();
        }

        private void btGenerar2_Click(object sender, EventArgs e)
        {
            deletes_TextChanged();
        }

        private void deletes_TextChanged()
        {
            this.deletes.Text = "DELETE FROM trliquidacion WHERE NumLiquidacion = '000" + tbLiquidacion.Text + "';" + "\n" +
            "DELETE FROM trdocumentosliquidacion WHERE NumLiquidacion = '000" + tbLiquidacion.Text + "';" + "\n" +
            "DELETE FROM treventosliquidacion WHERE NumLiquidacion = '000" + tbLiquidacion.Text + "';" + "\n" +
            "DELETE FROM trestadosliquidacion WHERE NumLiquidacion = '000" + tbLiquidacion.Text + "';" + "\n" +
            "DELETE FROM trdistribucionpago WHERE NumLiquidacion = '000" + tbLiquidacion.Text + "';" + "\n" +
            "DELETE FROM trliqbash WHERE NumLiquidacion = '000" + tbLiquidacion.Text + "';" + "\n" +
            "DELETE FROM trliquidacionerronea WHERE numliquidacion = '000" + tbLiquidacion.Text + "';";
           
        }

        private void btGenerar3_Click(object sender, EventArgs e)
        {
            querys_TextChanged();
        }

        private void querys_TextChanged()
        {
            this.querys.Text = "INSERT INTO cfncmeestado(CtaMedID, EstadoID, FecModEstado, FecModRegistro, UsuModRegistro, EstCod, NombreResponsable, Observacion, FecPago, MtoDescuadre) VALUES (" +
                tbCtaMedID.Text + ", " + tbEstadoID.Text + ", '" + dpFecha.Text + "', '" + dpFecha.Text + "', 'op'," + cbEstado.Text + ", 'IMED', 'Cambio de estado solicitado', '1900-01-01', 0);" + "\n" +
                "\n" + "UPDATE cfnctamedica SET EstCod = " + cbEstado.Text + ", FecModEstado = '" + dpFecha.Text + "' WHERE CtaMedID = " + tbCtaMedID.Text + "; ";
        }

        private void btgenerar4_Click(object sender, EventArgs e)
        {
            updates_TextChanged();
        }

        private void updates_TextChanged()
        {
            this.updates.Text = "UPDATE cfconvenioventa SET NombredelConvenio = '" + tbNombre.Text + "' WHERE CodIdConvenioVenta = " + tbCodIdConvenioVenta.Text + ";" + "\n" +
            "UPDATE cfconveniopago SET NombredelConvenio = '" + tbNombre.Text + "' WHERE CodIdConvenioPago = " + tbCodIdConvenioVenta.Text + ";";
        }

        private void imagen()
        {
            this.rbimagen.Text = "update cme.cfncmedoc set ctamedid =" + tbImg2.Text+ " where ctamedid ="+ tbImg1.Text +";";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imagen();
        }
    }
}
