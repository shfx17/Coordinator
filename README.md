# Coordinator
<b>Coordinator operates 7 servers</b>


The program was created in Visual Basic. The coordinator (client) runs 7 servers (the server is also the client). With the help of the coordinator, we can:
<br />-enable the server after specifying the file path
<br />-send a message,
<br />-connect to the server,
<br />-send a message to all servers,
<br />-send a message to all servers, if more servers are turned on (minimum 4 servers),
<br />-the program is licensed. The license is checked on the website. The program looks for a button named "key" using WebBrowser1.Navigate (). 
If such a button exists, the license is active. If it does not exist, the license is inactive,
<br />-using the server port, we can connect to another server, e.g. if the Kordynator has connected to the first server, then it can use it to 
display the data of any other server, e.g. using Server 2 to connect to Server 5, the message "133151" should be sent to Server 2. Each 
server has 3 pieces of information. To display the first piece of information, we pass the number 1 at the end of the port. Similarly 
with the following, up to 3. All combinations: "133151", "133152" and "133153",
<br />-check Status button allows you to check if we have a current license,
<br />-the Download file FTP button allows you to download a file from the FTP server (externally) without connection by means of a link,
<br />-if the Server receives the close () message from the Coordinator, the server is damaged and the connection cannot be completed,

PORTS:
<br />Server 1 - 13311
<br />Server 2 - 13312
<br />Server 3 - 13313
<br />Server 4 - 13314
<br />Server 5 - 13315
<br />Server 6 - 13316
<br />Server 7 - 13317

In CMD we can check listeners. You have to use <b>netstat -a</b> In the screen are Server 1 and Server 5 online.
<center>
<img src="https://i.ibb.co/cYj9RD3/netstat.png" alt="netstat" border="0">
</center>

Cordinator works ! :D
<center>
<a href="https://ibb.co/5RM4TT0"><img src="https://i.ibb.co/87KsMMC/2pc.png" alt="2pc" border="0"></a>
</center>
