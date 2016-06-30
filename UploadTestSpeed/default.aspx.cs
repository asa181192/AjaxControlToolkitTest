using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UploadTestSpeed.Models;
using System.Collections;
using System.Transactions; 

namespace UploadTestSpeed
{
    public partial class _default : System.Web.UI.Page
    {
        private DateTime time1,time2; 

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack) 
            {
                 this.Session["collectionName"] = new ArrayList();
                 this.Session["collectionExt"] = new ArrayList();
                 this.Session["file"] = new ArrayList();
            }
            
           
        }

        protected void Carga_Click(object sender, EventArgs e)
        {
            if(uploadaer.HasFile)
            {
                string   f = Path.GetFileName(uploadaer.PostedFile.FileName);
                string ex = Path.GetExtension(f);
                Stream fs =  uploadaer.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(fs);             
                (this.Session["collectionName"] as ArrayList).Add(f);
                (this.Session["collectionExt"] as ArrayList).Add(ex);

                Byte [] bytes = br.ReadBytes((Int32)fs.Length);
                (this.Session["file"] as ArrayList ).Add(bytes);

                lblCarga.Visible = true;
                lblCarga.Text = "archivo 1 Cargado";
            }        
        
        }

        protected void save_Click(object sender, EventArgs e)
        {

             /*  connection conn = new connection();
               lblTime.Visible = true;
               lblTime.Text= System.DateTime.Now.ToString("HH:mm:ss tt");
               ArrayList names = (this.Session["collectionName"] as ArrayList) ;
               ArrayList ext =  (this.Session["collectionExt"] as ArrayList) ;
               ArrayList files = (this.Session["file"] as ArrayList);
               conn.insertar(names[0].ToString(), ext[0].ToString(), files[0] as Byte[] );
               conn.insertar(names[1].ToString(), ext[1].ToString(), files[1] as Byte[] );
               conn.insertar(names[2].ToString(), ext[2].ToString(), files[2] as Byte[]);
               conn.insertar(names[3].ToString(), ext[3].ToString(), files[3] as Byte[]);
               conn.insertar(names[4].ToString(), ext[4].ToString(), files[4] as Byte[]);
               conn.insertar(names[5].ToString(), ext[5].ToString(), files[5] as Byte[]);
               (this.Session["collectionName"] as ArrayList).Clear();
               (this.Session["collectionExt"] as ArrayList).Clear();
               (this.Session["file"] as ArrayList).Clear();
               lblCarga.Visible = true;
               lblTime.Text += "<br /> : " +System.DateTime.Now.ToString("HH:mm:ss tt");
                
               lblCarga.Text = "Archivos cargados Individualmente";
              */
                
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (FileUpload1.HasFile)
            {
                string f1 = Path.GetFileName(FileUpload1.PostedFile.FileName);
                string ex1 = Path.GetExtension(f1);
                Stream fs = FileUpload1.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(fs);

                (this.Session["collectionName"] as ArrayList).Add(f1);
                (this.Session["collectionExt"] as ArrayList).Add(ex1);

                Byte[] bytes = br.ReadBytes((Int32)fs.Length);
                (this.Session["file"] as ArrayList).Add(bytes);
                lblCarga.Visible = true;
                lblCarga.Text = "archivo 2 Cargado";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (FileUpload2.HasFile)
            {
                string f2 = Path.GetFileName(FileUpload2.PostedFile.FileName);
                string ex2 = Path.GetExtension(f2);
                Stream fs = FileUpload2.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(fs);

                (this.Session["collectionName"] as ArrayList).Add(f2);
                (this.Session["collectionExt"] as ArrayList).Add(ex2);

                Byte[] bytes = br.ReadBytes((Int32)fs.Length);
                (this.Session["file"] as ArrayList).Add(bytes);
                lblCarga.Visible = true;
                lblCarga.Text = "archivo 3 Cargado";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (FileUpload3.HasFile)
            {
                string f3 = Path.GetFileName(FileUpload3.PostedFile.FileName);
                string ex3 = Path.GetExtension(f3);
                Stream fs = FileUpload3.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(fs);

                (this.Session["collectionName"] as ArrayList).Add(f3);
                (this.Session["collectionExt"] as ArrayList).Add(ex3);

                Byte[] bytes = br.ReadBytes((Int32)fs.Length);
                (this.Session["file"] as ArrayList).Add(bytes);
                lblCarga.Visible = true;
                lblCarga.Text = "archivo 4 Cargado";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (FileUpload4.HasFile)
            {
                string f4 = Path.GetFileName(FileUpload4.PostedFile.FileName);
                string ex4 = Path.GetExtension(f4);
                Stream fs = FileUpload4.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(fs);

                (this.Session["collectionName"] as ArrayList).Add(f4); //
                (this.Session["collectionExt"] as ArrayList).Add(ex4); // 

                Byte[] bytes = br.ReadBytes((Int32)fs.Length);
                (this.Session["file"] as ArrayList).Add(bytes);
                lblCarga.Visible = true;
                lblCarga.Text = "archivo 5 Cargado";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            if (FileUpload5.HasFile)
            {
                string f5 = Path.GetFileName(FileUpload5.PostedFile.FileName);
                string ex5 = Path.GetExtension(f5);
                Stream fs = FileUpload5.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(fs);

                (this.Session["collectionName"] as ArrayList).Add(f5);
                (this.Session["collectionExt"] as ArrayList).Add(ex5);

                Byte[] bytes = br.ReadBytes((Int32)fs.Length);
                (this.Session["file"] as ArrayList).Add(bytes);

                lblCarga.Visible = true;
                lblCarga.Text = "archivo 6 Cargado";
            }
        }

        protected void saveSP_Click(object sender, EventArgs e)
        {
           
            using (TransactionScope myscope = new TransactionScope()) 
            {
                connection conn = new connection();
                lblTime.Visible = true;
                time1 = DateTime.Parse(System.DateTime.Now.ToString("HH:mm:ss tt"));   
                lblTime.Text = System.DateTime.Now.ToString("HH:mm:ss tt");   
                
                
                ArrayList files = (this.Session["file"] as ArrayList);
                conn.insertar(files[0] as Byte[], files[1] as Byte[], files[2] as Byte[], files[3] as Byte[], files[4] as Byte[], files[5] as Byte[],"documentPDF",".pdf","valor Aleatorio","valor aleatorio","valor Aleatorio ");          
                (this.Session["file"] as ArrayList).Clear();
                lblCarga.Visible = true;
                time2 = DateTime.Parse( System.DateTime.Now.ToString("HH:mm:ss tt") );
                lblTime.Text += "<br /> " + System.DateTime.Now.ToString("HH:mm:ss tt");
                TimeSpan span =time2.Subtract(time1);
                lblTime.Text += "<br /> " + span;
                lblCarga.Text = "Archivos cargados por StoreProcedure ";

                myscope.Complete();

            }
          

        }

        protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
        {
          //  string filename = Path.GetFileName(AsyncFileUpload1.FileName);
          //  AsyncFileUpload1.SaveAs(Server.MapPath("~/files/")+filename); 
            Stream fs = AsyncFileUpload1.PostedFile.InputStream;
            BinaryReader br = new BinaryReader(fs);
            Byte[] bytes = br.ReadBytes((Int32)fs.Length);
            (this.Session["file"] as ArrayList).Add(bytes);

        }

        protected void AjaxFileUpload1_UploadComplete(object sender, AjaxControlToolkit.AjaxFileUploadEventArgs e)
        {
            Stream fs = e.GetStreamContents();
            BinaryReader br = new BinaryReader(fs);
            Byte[] bytes = br.ReadBytes((Int32)fs.Length);
            (this.Session["file2"] as ArrayList).Add(bytes);
        }

      
        protected void AjaxFileUpload1_UploadStart(object sender, AjaxControlToolkit.AjaxFileUploadStartEventArgs e)
        {
            this.Session["file2"] = new ArrayList();
        }

        protected void ajaxButtonUp_Click(object sender, EventArgs e)
        {
            using (TransactionScope myscope = new TransactionScope())
            {
                connection conn = new connection();
                lblTime.Visible = true;
                time1 = DateTime.Parse(System.DateTime.Now.ToString("HH:mm:ss tt"));
                lblTime.Text = System.DateTime.Now.ToString("HH:mm:ss tt");


                ArrayList files = (this.Session["file2"] as ArrayList);
                conn.insertar(files[0] as Byte[], files[1] as Byte[], files[2] as Byte[], files[3] as Byte[], files[4] as Byte[], files[5] as Byte[], "documentPDF", ".pdf", "valor Aleatorio", "valor aleatorio", "valor Aleatorio ");
                (this.Session["file"] as ArrayList).Clear();
                lblCarga.Visible = true;
                time2 = DateTime.Parse(System.DateTime.Now.ToString("HH:mm:ss tt"));
                lblTime.Text += "<br /> " + System.DateTime.Now.ToString("HH:mm:ss tt");
                TimeSpan span = time2.Subtract(time1);
                lblTime.Text += "<br /> " + span;
                lblCarga.Text = "Archivos cargados por StoreProcedure ";

                myscope.Complete();

            }
        }

      

       
    }   
   }
