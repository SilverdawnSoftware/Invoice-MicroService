// ALLOWOVERWRITE-F585110048A42E9642319A7F91469277-D3DE5310B4144DD14D6A15FDD0230880

					import {InvoiceStatus} from "../../Enums/InvoiceStatus"

    export interface IInvoiceView {
      billingAddressPostZipCode: string;		    			
      createdDate: string;    	
      dueDate: string;    	
      emailTo: string;    	
      grandTotal: number;    	
      invoiceEmailed: boolean;    	
      invoiceId: number;    	
      invoiceNo: number;    	
      notes: string;    	
      orderedBy: string;    	
      paidAmount: number;    	
      paidDate: string;    	
      paidTax: number;    	
      paymentDetails: string;    	
      purchaseOrderRef: string;    	
      shippingAddressPostZipCode: string;		    			
      status: InvoiceStatus;    	
      subTotal: number;    	
      taxTotal: number;    	
      termsAndConditions : string;    	

					    customerCustomerId : number;   
					    customerName : string;   
    }
    
    export class InvoiceView implements IInvoiceView {
      billingAddressPostZipCode: string;		    			
      createdDate: string;    	
      dueDate: string;    	
      emailTo: string;    	
      grandTotal: number;    	
      invoiceEmailed: boolean;    	
      invoiceId: number;    	
      invoiceNo: number;    	
      notes: string;    	
      orderedBy: string;    	
      paidAmount: number;    	
      paidDate: string;    	
      paidTax: number;    	
      paymentDetails: string;    	
      purchaseOrderRef: string;    	
      shippingAddressPostZipCode: string;		    			
      status: InvoiceStatus;    	
      subTotal: number;    	
      taxTotal: number;    	
      termsAndConditions : string;    	

					    customerCustomerId : number ;   
					    customerName : string;   


	  constructor() {
	  }
    }

