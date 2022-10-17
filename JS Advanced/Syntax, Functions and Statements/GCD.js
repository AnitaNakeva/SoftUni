function greatestCD(num1, num2) {
       a = Math.abs(num1);
       b = Math.abs(num2);
       let divisor=GetDivisor(a,b);
       resultDiv.textContent=divisor;
  
       function GetDivisor(a,b){
            
       if (b > a) {var temp = a; a = b; b = temp;}
       while (true) {
           if (b == 0) return  a;
           a %= b;
           if (a == 0) return b;          
           b %= a;
           
       }  
    }
 }

 greatestCD(15,5);