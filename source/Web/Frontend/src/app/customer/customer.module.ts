import { CommonModule, registerLocaleData } from "@angular/common";
import locale from "@angular/common/locales/pt";
import { LOCALE_ID, NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { RouterModule, Routes } from "@angular/router";
import { PipesModule } from "../pipes/pipes.module";
import { CustomerComponent } from "./customer.component";

registerLocaleData(locale);

const routes: Routes = [
    { path: "", component: CustomerComponent }
];

@NgModule({
    declarations: [CustomerComponent],
    imports: [
        CommonModule,
        FormsModule,
        PipesModule,
        RouterModule.forChild(routes)
    ],
    providers: [
        {
            provide: LOCALE_ID,
            useValue: "pt-BR"
        }
    ]
})
export class CustomerModule { }
