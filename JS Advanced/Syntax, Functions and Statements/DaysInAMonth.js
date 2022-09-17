function getDaysInAMonth(month, year) {
   let datee = new Date(year, month, 0).getDate();
   consol.log(datee);
};

getDaysInAMonth(1, 2012);