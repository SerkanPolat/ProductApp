﻿using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Interfaces.Repository
{
	public interface IProductRepository : IGenericRepository<Product>
	{
		// Dont Repeat Yourself

	}
}
