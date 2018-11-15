<!-- default file list -->
*Files to look at*:

* [frmMain.cs](./CS/frmMain.cs) (VB: [frmMain.vb](./VB/frmMain.vb))
<!-- default file list end -->
# OBSOLETE - How to implement a crosshair cursor and highlight the corresponding point


<p><strong>Note: This example applies to an XtraCharts version prior to v2012 vol 1. Starting from v2012 vol 1, a crosshair cursor is provided out-of-the-box and is enabled by default for all XY-series views.</strong></p><p>The following example demonstrates a useful way to add interactivity to your WinForms charts. In this sample, it is illustrated how to add constant lines that are moved following the current position of the mouse pointer and indicate the current argument and value positions on the X and Y axes.</p><p>An example of this chart is shown in the image below.</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/obsolete-how-to-implement-a-crosshair-cursor-and-highlight-the-corresponding-point-e890/10.2.3+/media/b908578d-075f-4f8e-99a4-17b7689a8aac.png"></p>


<h3>Description</h3>

<p>To generate a crosshair cursor, you should add two <a href="http://help.devexpress.com/#XtraCharts/CustomDocument1984">Constant Lines</a> and change their values according to the mouse position. For this, handle a chart&#39;s <strong>MouseMove</strong> event, and in its event handler, call the <a href="http://documentation.devexpress.com/#XtraCharts/DevExpressXtraChartsXYDiagram2D_PointToDiagramtopic">XYDiagram2D.PointToDiagram</a> method to convert pixel coordinates to diagram coordinates.</p>

<br/>


