select Count(Room) from Reservation_tbl where Room = '" + idNow + "' and " + "ResId!='"+resIdNow+
                           "'(DateIn between '" + dtIn + "' and '" + dtOut + "') or " +
                           "(DateOut betweendtIn ' and '" + dtOut + "')or" +
                           "(DateIn <=  dtIn  and DateOut >=  dtOut ) group by Room ;