<%@ Page Language="C#" Inherits="Room_Calc.Default" %>
    <!DOCTYPE html>
    <html>

    <head runat="server">
        <title>Room</title>
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">

        <!-- jQuery library -->
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>

        <!-- Latest compiled JavaScript -->
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
        <style>
            .note {
                text-align: center;
                height: 80px;
                background: -webkit-linear-gradient(left, #0072ff, #8811c5);
                color: #fff;
                font-weight: bold;
                line-height: 80px;
            }
            
            .form-content {
                padding: 5%;
                border: 1px solid #ced4da;
                margin-bottom: 2%;
            }
            
            .form-control {
                border-radius: 1.5rem;
            }
            
            .btnSubmit {
                border: none;
                border-radius: 1.5rem;
                padding: 1%;
                
                cursor: pointer;
                background: #0062cc;
                color: #fff;
                width: 80%;
margin-left: 10%;
margin-right: 10%;
            }
        </style>
    </head>

    <body>
        <form id="form1" runat="server">

            <div class="container register-form">
                <div class="form">
                    <div class="note">
                        <asp:Label id="label" Text="Room maintenance" runat="server" />
                        
                     
                    </div>

                    <div class="form-content">
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <input type="text" id="id_length" class="form-control" placeholder="Length" value="" runat="server" />
                                </div>
                                <div class="form-group">
                                    <select class="form-control" id="id_material" runat="server" >


                                    </select>
                                </div>
                                <div class="form-group">
                                    <select class="form-control" id="id_color" runat="server">

                                        

                                    </select>
                                </div>

                                <div class="form-group">
                                    <input type="text" class="form-control" id="id_employees" placeholder="Number of employees" value="" runat="server" />
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <input type="text" class="form-control" id="id_width" placeholder="Width" value="" runat="server" />
                                </div>
                                <div class="form-group">
                                    <input type="text" class="form-control" id="id_material_cost" placeholder="Material 1m2 cost" value="" runat="server" />
                                </div>
                                <div class="form-group">
                                    <input type="text" class="form-control" id="id_color_cost" placeholder="Color 1m2 cost" value="" runat="server" />
                                </div>
                                <div class="form-group">
                                    <input type="text" class="form-control" id="id_salary" placeholder="Salary" value="" runat="server" />
                                </div>
                            </div>
                        </div>
                        <asp:Button id="button1" runat="server" class="btnSubmit" Text="Calculate" OnClick="button1Clicked" />

                    </div>
                </div>
            </div>
        </form>
    </body>

    </html>