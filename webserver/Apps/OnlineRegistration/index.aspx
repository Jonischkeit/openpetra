<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
    <title>Sample Registration</title>

    <link rel="stylesheet" type="text/css" href="../../css/ext-all.css"/>
    
    <!-- Ext.ux.Wiz stylesheet -->
    <link rel="stylesheet" type="text/css" href="../../css/ext-ux-wiz.css" />
    
    <script type="text/javascript" src="../../js/ext-base.js"></script>
    <script type="text/javascript" src="../../js/ext-all.js"></script>

    <!-- Ext.ux.Wiz files -->
    <script type="text/javascript" src="../../js/Ext.ux.Wiz/CardLayout.js"></script>
    <script type="text/javascript" src="../../js/Ext.ux.Wiz/Wizard.js"></script>
    <script type="text/javascript" src="../../js/Ext.ux.Wiz/Header.js"></script>
    <script type="text/javascript" src="../../js/Ext.ux.Wiz/Card.js"></script>
    
    <link rel="stylesheet" type="text/css" href="../../css/fileuploadfield.css"/>
    <script type="text/javascript" src="../../js/FileUploadField.js"></script>

    <script type="text/javascript" src="gen/main.js"></script>
    <style type=text/css>
        .upload-icon {
            background: url('../../img/image_add.png') no-repeat 0 0 !important;
        }
    </style>

<script type="text/javascript">
    <!-- 
    Ext.BLANK_IMAGE_URL = '../../img/default_blank.gif';
    Ext.onReady(function() {
        Ext.QuickTips.init();
        Ext.form.Field.prototype.msgTarget = 'side';

        MainForm = new TMainForm();
        MainForm.show();
        // this is required for smaller screens, otherwise the scrollbars don't work properly
        MainForm.setPosition(0,0);
        
        UploadForm = new TUploadForm();
        UploadForm.render('uploadDiv');
        
        });
    -->
</script>    
</head>

<body>
<div style="height:805px;"/> <!-- this div helps with the background color for smaller screens -->
<div id="mainFormDiv"></div>
<div id="uploadDiv" style="visibility:hidden"></div>
</body>
</html>
    