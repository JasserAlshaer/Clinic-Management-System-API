﻿using ClinicManagmentAPI.DTOs.Invoice;
{
	public interface IInvoiceService
	{
		Task<List<InvoiceDTO>>GetAllInvoice( );
		Task CreateInvoice(InvoiceCreateDTO dto);
}
