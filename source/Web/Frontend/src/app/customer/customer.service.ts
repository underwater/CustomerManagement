import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Customer } from "./customer.model";

@Injectable({ providedIn: "root" })
export class CustomerService {
    constructor(private readonly http: HttpClient) { }

    get() {
        return this.http.get<Customer[]>("Customer");
    }
}
