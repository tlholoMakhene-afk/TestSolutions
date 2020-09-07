var alphabet = new Array(26);//creating an array with a capacity of 26 to represent the alphabets
for (var i = 0; i < 26; i++){//iterate from 0 to 25 
    alphabet[i] = String.fromCharCode(i+65); //method returns a string created from the specified sequence of UTF-16 code units in this case it is the (i+65)
    console.log(alphabet[i]);
}