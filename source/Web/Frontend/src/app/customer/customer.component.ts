import { Component } from "@angular/core";
import { Customer } from "./customer.model";
import { CustomerService } from "./customer.service";

@Component({ selector: "app-customer", templateUrl: "./customer.component.html" })
export class CustomerComponent {
    customers: Customer[];
    search: string;

    constructor(private readonly customerService: CustomerService) {
        this.customerService.get().subscribe((customers) => this.customers = customers);
    }
}
