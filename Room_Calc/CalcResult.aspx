<%@ Page Language="C#" %>
<!DOCTYPE>
<html>
<head runat="server">
    <title>Room Maintanence</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
</head>
<style>
    form {
        background-color:lightGray;
        color:white;
        width: 600px;
        border-radius: 5px;
        margin: auto;
        margin-top: 150px;
        padding: 15px;
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
    }
    .center {
        text-align: center;
    }
 
    button{
        margin-top:20px;
    }
</style>
<body>
<form >
   <div class="center">
       <h3> Description: <span  id="desc" ><%=Request["desc"]%></span></h3>
       <h3> Color: <span><%=Request["color"]%> </span></h3>
       <h3>Total cost for room: <span id="amount" ><%=Request["total"]%> AZN</span></h3>
       <h3>Employees: <span><%=Request["worker"]%></span></h3>
       <h3>Employee Salary: <span id="salary" ><%=Request["salary"]%> AZN</span></h3>
        <h3>Amount: <span id="money" ><%=Request["money"]%> AZN</span></h3>
   </div>
      <div class="center">
        <button  type="button" class="btn btn-secondary btn-lg btn-block" onclick="window.location.href ='/'">Back</button>
    </div>
</form>
</body>
</html>