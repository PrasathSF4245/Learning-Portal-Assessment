
function PriceValidation(){

    var price = document.getElementById("price");
    var regex = /^[a-zA-Z`!@#$%^&*()_\-+=\[\]{};':"\\|,.<>\/?~ ]+$/;
    var form = document.getElementById("forms");
    var invalidprice = document.getElementById("invalidprice");
    var bookprice=price.value;
    if (price.value.trim() == "" || price.value.trim() == null) {
        // alert("Price Feild Cannort be empty");
        document.getElementById("price").style.border = "solid 4px red";
        invalidprice.innerHTML="Price Feild Cannort be empty";
        form.classList.add("invalid");
        form.classList.remove("valid");
    }
  else  if (regex.test(bookprice) ) {
       // alert("Price Feild should be numbers");
        document.getElementById("price").style.border = "solid 4px red";
        invalidprice.innerHTML="Price Feild should be numbers";
        form.classList.add("invalid");
        form.classList.remove("valid");
    }
    else  if (bookprice<=0)  {
        // alert("Price Feild should be  valid numbers");
         document.getElementById("price").style.border = "solid 4px red";
         invalidprice.innerHTML="Price Feild should be valid numbers";
         form.classList.add("invalid");
         form.classList.remove("valid");
     }
    else
    {
        form.classList.remove("invalid");
        form.classList.add("valid");
        invalidprice.innerHTML = "";
        document.getElementById("price").style.border = "solid 2px black";
    }
}
var checksave=false;
function Save() {
    
    var books = {
        
        price: document.getElementById("price").value,
        bookname: document.getElementById("bookname").value,
        Authorname: document.getElementById("Authorname").value,
        Authoremail: document.getElementById("Authoremail").value,
        Publishyear: document.getElementById("Publishyear").value,
        dpt: document.getElementById("dpt").value
    }
    if(books.price==""&& books.Authorname=="" && books.Publishyear=="" &&books.bookname==""&&books.dpt=="select" ){checksave=false;}
    else{checksave=true;}

    localStorage.setItem("price", books.price);
    localStorage.setItem("Author name", books.Authorname);
    localStorage.setItem("Author Email", books.Authoremail);
    localStorage.setItem("Published  Year", books.Publishyear);
    localStorage.setItem("Book", books.bookname);
    localStorage.setItem("Category", books.dpt);

}
function aftersubmit()
{
    var form = document.getElementById("forms");
        var checkentries = document.getElementById("checkentries");
    if(!checksave)
    {
        checkentries.innerHTML="Enter the entries and save before proceed";
        form.classList.add("invalid");
        form.classList.remove("valid");
        return false;
    }
    else
    {
        form.classList.remove("invalid");
        form.classList.add("valid");
        checkentries.innerHTML = ""; 
        return true;
    }
}
function PublishyearValidation() {
    var Publishyear = document.getElementById("Publishyear");
    var form = document.getElementById("forms");
    var invalidPublishyear = document.getElementById("invalidPublishyear");
    let year = Publishyear.value;
    var regex = /^[a-zA-Z`!@#$%^&*()_\-+=\[\]{};':"\\|,.<>\/?~ ]+$/;
    const d = new Date();
    let currentyear = d.getFullYear();
    if (Publishyear.value.trim() == "" || Publishyear.value.trim() == null) {
        
        document.getElementById("Publishyear").style.border = "solid 4px red";
        invalidPublishyear.innerHTML="Publish Year Feild Cannort be empty";
        form.classList.add("invalid");
        form.classList.remove("valid");
    }

    else if (regex.test(year)) {
        document.getElementById("Publishyear").style.border = "solid 4px red";
        invalidPublishyear.innerHTML="Publish Year Feild should be numbers";
        form.classList.add("invalid");
        form.classList.remove("valid");
    }

    else if (year > currentyear) {
      
        document.getElementById("Publishyear").style.border = "solid 4px red";
        invalidPublishyear.innerHTML="Please enter valid Published year";
        form.classList.add("invalid");
        form.classList.remove("valid");
    }
    else
    {
        form.classList.remove("invalid");
        form.classList.add("valid");
        invalidPublishyear.innerHTML = "";
        document.getElementById("Publishyear").style.border = "solid 2px black";
    }

}


function AuthoremailValidation() {
    var Authoremail = document.getElementById("Authoremail");
    var form = document.getElementById("forms");
    var invalidAuthoremail = document.getElementById("invalidAuthoremail");
    var inputText = Authoremail.value;
    console.log(inputText.includes(".com"));
    let mailformat = /[`!@#$%^&*()_\-+=\[\]{};':"\\|,.<>\/?~ ]/;
    if (Authoremail.value.trim() == "" || Authoremail.value.trim() == null) {
        // alert("Author email Feild Cannort be empty");
        document.getElementById("Authoremail").style.border = "solid 4px red";
        form.classList.add("invalid");
        form.classList.remove("valid");
        invalidAuthoremail.innerHTML = "Author email Feild cannot be a empty";
    }

    // else if (mailformat.test(inputText)) {
       else if(!(inputText.includes(".com"))){
        
        //  alert("Author email is invalid");
        document.getElementById("Authoremail").style.border = "solid 4px red";
        form.classList.add("invalid");
        form.classList.remove("valid");
        invalidAuthoremail.innerHTML = "Author email is invalid";
        
    }
    else {
        form.classList.remove("invalid");
        form.classList.add("valid");
        invalidAuthoremail.innerHTML = "";
        document.getElementById("Authoremail").style.border = "solid 2px black";
    }

}

function AuthornameValidation() {
    var form = document.getElementById("forms");
    var Authorname = document.getElementById("Authorname");
    var authornameeorr = document.getElementById("Authornameerror");
    var lengthofAuthorname = Authorname.value;
    var regex = /^[a-zA-Z`!@#$%^&*()_\-+=\[\]{};':"\\|,.<>\/?~ ]+$/;
    let specialChars = /[`!@#$%^&*()_\-+=\[\]{};':"\\|,.<>\/?~ ]/;

    if (Authorname.value.trim() == "" || Authorname.value.trim() == null) {
        // alert("Author name Feild Cannort be empty");
        document.getElementById("Authorname").style.border = "solid 4px red";
        form.classList.add("invalid");
        form.classList.remove("valid");
        authornameeorr.innerHTML = "Author Feild cannot be a empty";

    }

    else if (regex.test(lengthofAuthorname) == false) {
        // alert("Author Name Feild Cannort contain numbers");
        document.getElementById("Authorname").style.border = "solid 4px red";
        form.classList.add("invalid");
        form.classList.remove("valid");
        authornameeorr.innerHTML = "Author Feild cannot be a numbers";
    }

    else if (specialChars.test(lengthofAuthorname)) {
        //  alert("Author Name Feild Cannort contain special characters");
        document.getElementById("Authorname").style.border = "solid 4px red";
        form.classList.add("invalid");
        form.classList.remove("valid");
        authornameeorr.innerHTML = "Author Feild cannot be a special characters";
    }

    else if ((lengthofAuthorname).length >= 50) {

        //  alert("Book name length should not exceed 50");
        document.getElementById("Authorname").style.border = "solid 4px red";
        form.classList.add("invalid");
        form.classList.remove("valid");
        authornameeorr.innerHTML = "Author name length should not exceed 50";
    }
    else {
        form.classList.remove("invalid");
        form.classList.add("valid");
        authornameeorr.innerHTML = "";
        document.getElementById("Authorname").style.border = "solid 2px black";
    }

}


function Booknamevalidation() {

    var form = document.getElementById("forms");
    var bookName = document.getElementById("bookname");
    var booknameeror = document.getElementById("booknameeror");
    var lengthofbookname = bookName.value;
    var regex = /^[a-zA-Z]+$/;
    console.log(typeof (bookName));

    if ((bookName.value.trim() == "" || bookName.value.trim() == null)) {
        // form.classList.add("invalid");
        // form.classList.remove("valid");
        booknameeror.innerHTML = "book Name Feild Cannort be empty"
        document.getElementById("bookname").style.border = "solid 4px red";

    }
    else if (regex.test(lengthofbookname) == false) {

        // form.classList.add("invalid");
        // form.classList.remove("valid");
        document.getElementById("bookname").style.border = "solid 4px red ";
        booknameeror.innerHTML = "book Name Feild should not be numbers"

    }

    else if (lengthofbookname.length >= 50) {

        form.classList.add("invalid");
        form.classList.remove("valid");
        document.getElementById("bookname").style.border = "solid 4px red";
        booknameeror.innerHTML = "book Name Feild should not exced more than 50 characters"
        document.getElementById("bookname").style.border = "solid 4px red";
        return false;
    }
    else {
        form.classList.remove("invalid");
        form.classList.add("valid");
        booknameeror.innerHTML = "";
        document.getElementById("bookname").style.border = "solid 2px black";
    }
}