import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { FooterComponent } from "./footer/footer.component";
import { HeaderComponent } from "./header/header.component";
import { LayoutComponent } from "./layout.component";
import { MainComponent } from "./main/main.component";

@NgModule({
    declarations: [
        FooterComponent,
        HeaderComponent,
        LayoutComponent,
        MainComponent
    ],
    imports: [RouterModule]
})
export class LayoutModule { }
