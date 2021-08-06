<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmDefault.aspx.cs" Inherits="SIME.frmDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
        <script language="JavaScript" type="text/javascript">
           function show5() {
               if (!document.layers && !document.all && !document.getElementById)
                   return

               var Digital = new Date()
               var hours = Digital.getHours()
               var minutes = Digital.getMinutes()
               var seconds = Digital.getSeconds()

               var dn = "PM"
               if (hours < 12)
                   dn = "AM"
               if (hours > 12)
                   hours = hours - 12
               if (hours == 0)
                   hours = 12
                
               //if (minutes <= 9)
                   minutes = "" + minutes
               if (seconds <= 9)
                   seconds = "0" + seconds
               //change font size here to your desire
               myclock = "<font size='5' face='Arial' ><b><font size='1'>Hora actual:</font></br>" + hours + ":" + minutes + ":"
                   + seconds + " " + dn + "</b></font>"
               if (document.layers) {
                   document.layers.liveclock.document.write(myclock)
                   document.layers.liveclock.document.close()
               }
               else if (document.all)
                   liveclock.innerHTML = myclock
               else if (document.getElementById)
                   document.getElementById("liveclock").innerHTML = myclock
               setTimeout("show5()", 1000)
           }
           window.onload = show5
             //-->
         </script>
        <br />
        <div class="carousel slide" style="width:100% !important; min-height:450px;margin-left:-10px;padding:5px;">
        <%--Contenido--%>
           <div class="w3-content w3-section" style="width:99%">
              <img class="mySlides w3-animate-fading" src="images/slide/plomeria.jpg" style="width:100%">
              <img class="mySlides w3-animate-fading" src="images/slide/remodelacion.jpg" style="width:100%">
              <img class="mySlides w3-animate-fading" src="images/slide/electricidad.jpg" style="width:100%">
            </div>
        </div>
        <div style="text-align:right;width:100%;">
           <span id="liveclock"></span>
        </div>
    <script>
    var myIndex = 0;
    carousel();

    function carousel() {
      var i;
      var x = document.getElementsByClassName("mySlides");
      for (i = 0; i < x.length; i++) {
        x[i].style.display = "none";  
      }
      myIndex++;
      if (myIndex > x.length) {myIndex = 1}    
      x[myIndex-1].style.display = "block";  
      setTimeout(carousel, 9000);    
    }
    </script>
</asp:Content>
