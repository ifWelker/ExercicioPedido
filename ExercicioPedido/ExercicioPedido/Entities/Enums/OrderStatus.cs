﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPedido.Entities.Enums
{
    enum OrderStatus
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 1,
        Delivered = 2,
    }
}