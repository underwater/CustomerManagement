import { Routes } from "@angular/router";
import { LayoutComponent } from "./layout/layout.component";

export const routes: Routes = [
    {
        children: [
            { path: "", loadChildren: "./customer/customer.module#CustomerModule" }
        ],
        component: LayoutComponent,
        path: ""
    },

    { path: "**", redirectTo: "" }
];
