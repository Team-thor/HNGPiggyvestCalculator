$(document).ready( () => {
    $("#send").click( () => {
        
        let amount = Number( $("#amount-invested").val() );
        let month = Number( $("#interest-period").val() );
        let rate = Number( $("#interest-rate").val() ); 

        let interest = ( amount * month * rate ) / 100;
        let totalBalance = interest + amount;

        document.getElementById("message-text").textContent = `Hello! Your prospective earnings will be as follows: \nInterest: ${interest} \nTotal Earning: ${totalBalance}`
    });
    $("#close").click( ()=> {
        document.getElementById("message-text").textContent = " "
    })


})