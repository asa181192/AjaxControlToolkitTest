<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="UploadTestSpeed._default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
    <link rel="stylesheet" href="~/Css/style.css" />
</head>
    
<body>
    <form id="form1" runat="server">
    <div class="WebFormsCotrols">

        <div id="UploadCenter">    
                
        <h1>Speed Upload Data</h1>
        <asp:FileUpload id="uploadaer" runat="server"/>
        <asp:Button ID="Carga" Text="upload" runat="server" OnClick="Carga_Click" />
        <br />
        <br />
        <asp:FileUpload id="FileUpload1" runat="server"/>
        <asp:Button ID="Button1" Text="upload" runat="server" OnClick="Button1_Click" />
        <br />
        <br />
         <asp:FileUpload id="FileUpload2" runat="server"/>
        <asp:Button ID="Button2" Text="upload" runat="server" OnClick="Button2_Click" />
        <br />
        <br />
         <asp:FileUpload id="FileUpload3" runat="server"/>
        <asp:Button ID="Button3" Text="upload" runat="server" OnClick="Button3_Click" />
        <br />
        <br />
         <asp:FileUpload id="FileUpload4" runat="server"/>
        <asp:Button ID="Button4" Text="upload" runat="server" OnClick="Button4_Click" />
        <br />
        <br />
         <asp:FileUpload id="FileUpload5" runat="server"/>
        <asp:Button ID="Button5" Text="upload" runat="server" OnClick="Button5_Click" />
        <br />
        <br />
        <asp:Button ID="save" Text="Grabar inidvidual" visible="false" runat="server" OnClick="save_Click"  />
        <asp:Button ID="saveSP" Text="Grabar SP" runat="server" OnClick="saveSP_Click"  />
        <br />
        <br />
  

          <asp:Label id="lblTime" Visible="false" text="" runat="server"/>
        <br />
        <br />

        <asp:Label id="lblCarga" Visible="false" text="Waiting" runat="server"/>
        </div>
    </div>
        
    <div class="WebFormsCotrols" >
        <ajaxToolkit:AsyncFileUpload ID="AsyncFileUpload1" runat="server" OnUploadedComplete="AsyncFileUpload1_UploadedComplete" 
        OnClientUploadError="uploadError" OnClientUploadComplete="uploadComplete" ThrobberID="imageGif"
         UploadingBackColor="LightBlue"
             />
         <asp:Image ID="imageGif" runat="server" ImageUrl="~/files/gears.gif"  Height="37px" Width="45px"/>
        <br />
         <asp:Label ID="lblMesg" runat="server"></asp:Label>

    </div>

        <div class="WebFormsCotrols">
           <ajaxToolkit:AjaxFileUpload ID="AjaxFileUpload1" runat="server" OnUploadComplete="AjaxFileUpload1_UploadComplete"
                style="margin-top: 2px" MaximumNumberOfFiles="6"
               AllowedFileTypes="txt,jpg" ThrobberID="imageGif" OnUploadStart="AjaxFileUpload1_UploadStart" UseAbsoluteHandlerPath="false"/>
            <asp:Button id="ajaxButtonUp" runat="server" Text="Grabar" OnClick="ajaxButtonUp_Click"/>
        </div>

       <asp:ScriptManager ID="ScriptManager1" runat="server"  >
        </asp:ScriptManager>
        
    </form>
    
        <script type="text/javascript">
             count = 0;
            function uploadComplete(sender) {
                count = count + 1; 
                    $get("<%=lblMesg.ClientID%>").innerHTML = "Archivo "+count+" cargado Exitosamente";
                   
                }

                function uploadError(sender) {
                    $get("<%=lblMesg.ClientID%>").innerHTML = "Fallo al cargar el archivo";
                }

             
            </script>
</body>
    
</html>
