<%@ Page Language="C#" MasterPageFile="~/GlobalMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
 
 <%--    ////////////////////////////Facebook //////////////////////--%>

<div id="fb-root"></div>
<script>(function(d, s, id) {
  var js, fjs = d.getElementsByTagName(s)[0];
  if (d.getElementById(id)) return;
  js = d.createElement(s); js.id = id;
  js.src = "//connect.facebook.net/en_US/all.js#xfbml=1&appId=235944343200183";
  fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>





    
<%--    ////////////////////////////News Slider //////////////////////--%>



<script type="text/javascript">
$(document).ready(function(){
  var currentPosition = 0;
  var slideWidth = 323;
  var slides = $('.slide');
  var numberOfSlides = slides.length;

  // Remove scrollbar in JS
  $('#slidesContainer').css('overflow', 'hidden');

  // Wrap all .slides with #slideInner div
  slides
    .wrapAll('<div id="slideInner"></div>')
    // Float left to display horizontally, readjust .slides width
	.css({
      'float' : 'left',
      'width' : slideWidth
    });

  // Set #slideInner width equal to total width of all slides
  $('#slideInner').css('width', slideWidth * numberOfSlides);

  // Insert controls in the DOM
  $('#slideshow')
    .prepend('<span class="control" id="leftControl">Clicking moves left</span>')
    .append('<span class="control" id="rightControl">Clicking moves right</span>');

  // Hide left arrow control on first load
  manageControls(currentPosition);

  // Create event listeners for .controls clicks
  $('.control')
    .bind('click', function(){
    // Determine new position
	currentPosition = ($(this).attr('id')=='rightControl') ? currentPosition+1 : currentPosition-1;
    
	// Hide / show controls
    manageControls(currentPosition);
    // Move slideInner using margin-left
    $('#slideInner').animate({
      'marginLeft' : slideWidth*(-currentPosition)
    });
  });

  // manageControls: Hides and Shows controls depending on currentPosition
  function manageControls(position){
    // Hide left arrow if position is first slide
	if(position==0){ $('#leftControl').hide() } else{ $('#leftControl').show() }
	// Hide right arrow if position is last slide
    if(position==numberOfSlides-1){ $('#rightControl').hide() } else{ $('#rightControl').show() }
  }	
});
</script>
   <%-- ///////////////////////////--%>
 <%--    ////////////////////////////scheduleAuto //////////////////////--%>  
<script type="text/javascript"> 
var auto_refresh = setInterval(
function()
{
$('#loaddiv').fadeOut('slow').load('scheduleAuto.aspx').fadeIn("slow");
}, 100000);
</script>


<script type="text/javascript"> 
var auto_refresh = setInterval(
function()
{
$('#loaddiv1').fadeOut('slow').load('schedule2Auto.aspx').fadeIn("slow");
}, 100000);
</script>
 <%--    ////////////////////////////scheduleAuto //////////////////////--%>  



 <%--    ////////////////////////////Schedule - input effect //////////////////////--%>   

    <script src="scripts/jquery.hint.js" type="text/javascript"></script>	
    <script type="text/javascript" charset="utf-8">
			$(function(){ 
			    // find all the input elements with title attributes
				$('input[title!=""]').hint();
			});
		</script>
  <%--    ////////////////////////////Schedule - input effect //////////////////////--%>  
  
   	<script type="text/javascript" src="./fancybox/jquery.mousewheel-3.0.4.pack.js"></script>
	<script type="text/javascript" src="./fancybox/jquery.fancybox-1.3.4.pack.js"></script>
	<link rel="stylesheet" type="text/css" href="./fancybox/jquery.fancybox-1.3.4.css" media="screen" />

	<script type="text/javascript">
		$(document).ready(function() {
			/*
			*   Examples - images
			*/
			/*
			*   Examples - various
			*/

			$("#various1").fancybox({
			
				'titlePosition'		: 'inside',
				'transitionIn'		: 'none',
				'transitionOut'		: 'none',
				
				'overlayColor'		: '#000',
				'overlayOpacity'	: 0.9
			});

			
		});
	</script> 
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
     </asp:ScriptManager>
  <div class="sidebar1">
  
              <div class="slider"  id="sliderimage" runat="server" >

              <%--   <a href="http://www.google.com"> <img src="images/toystory.jpg" alt="" /></a>
                <a href="http://dev7studios.com"><img src="images/up.jpg" alt="" title="This is an example of a caption" /></a>
                <img src="images/walle.jpg" alt="" />
                <img src="images/nemo.jpg" alt="" title="#htmlcaption" />--%>
            </div><!--end of .slider-->
          <%-- new hany--%>
            <div id="caption" runat="server"  >

</div>
<%-- new hany--%>
    <div id="Div1" runat="server">
    </div>
    <%-- new hany--%>
    <!-- end .sidebar1 -->
    </div>
    <div class="sidebar2" id="adbanner" runat="server">
        <div class="box05">
<iframe width="290" height="252" src="//www.youtube.com/embed/mham3S9K67Q" frameborder="0" allowfullscreen></iframe>
        </div>
        <!-- end .sidebar2 -->
    </div>
    
  <div class="content">
<div class="box01"> <h2>TNTV News</h2>

 <div id="slideshow">
    <div id="slidesContainer"   >
    <div id="News" runat="server">
    

   
    </div>
    <span class="clearfloat"></span>
    </div>  

<!-- end .slideshow --></div><!-- end .box01 --></div>


<!--schedule 1-->	
<div class="box03" id="loaddiv"  >
    <h2>Schedule</h2>
<div class="box03-01" id="Schedule" runat="server"  >
</div>
</div>


	<div style="display: none;">
		<div id="inline1" style="width:550px;height:200px;overflow:auto; padding:5px; border:2px solid #ed1f24">
<div class='f-b-03'><img alt="Al Kahera Wal Nas 2" title="Al Kahera Wal Nas 2" src="images/TNTV-02-02.png" />	
Watch the Repeat of Al Kahera Wal Nas Broadcast Programming, 

2 Hours After its Airing Time on Al Kahera Wal Nas</div>

<ul class="ul-01">
<li>Frequency: 11430</li>
<li>Polarization: Vertical</li>
<li>FEC: 3/4 </li>
<li> Symbol Rate: 27500</li>
</ul>
</div>
	</div>
	</div>

<!-- schedule 2 -->
<div class="box03" id="Div4"  >
    <h2>Schedule 2</h2>
<div class="box03-01" id="Schedule1" runat="server"  >
</div>
</div>


<div class="box04"><h2>Newsletter</h2>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
 <ContentTemplate >
<div class="box04-01" >

                  <asp:Label ID="Label1" runat="server"  Visible="False" CssClass="f-w-01" 
                      EnableTheming="False"></asp:Label>
                  <input name="input1" type="text" id="txtname"  class="input-01"  title="- Name -" runat="server" />
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname"
                      ErrorMessage="*"  Display="Dynamic" ForeColor="White"></asp:RequiredFieldValidator>
                  <input name="input1" type="text" id="txtemail" class="input-01"   title="- Email -" runat="server" />
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2"  Display="Dynamic"  runat="server" ControlToValidate="txtemail"
                      ErrorMessage="*" ForeColor="White"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail"
                      ErrorMessage="Not a vaild email"  Display="Dynamic"  
                      ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                      ForeColor="White"></asp:RegularExpressionValidator>
                 
                     <div class="align-right"> <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" CssClass="L-01">Unsubscribe</asp:LinkButton></div>
    <div class="align-center">  <asp:ImageButton ImageUrl="images/Register-01.png" 
            id="Button1"  runat="server" 
            onclick="Button1_Click" /></div>
<%--<img src="images/ramadana.jpg" />--%>
    </div> 
  </ContentTemplate>
     </asp:UpdatePanel>
   <!-- end .box04 -->          </div>

    <!-- end .content --></div>



</asp:Content>

