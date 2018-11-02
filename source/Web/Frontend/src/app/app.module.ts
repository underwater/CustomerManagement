import { registerLocaleData } from "@angular/common";
import { HttpClientModule } from "@angular/common/http";
import locale from "@angular/common/locales/pt";
import { LOCALE_ID, NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule } from "@angular/router";
import { AppComponent } from "./app.component";
import { routes } from "./app.routes";
import { LayoutModule } from "./layout/layout.module";

registerLocaleData(locale);

@NgModule({
    bootstrap: [AppComponent],
    declarations: [AppComponent],
    imports: [
        BrowserModule,
        HttpClientModule,
        RouterModule.forRoot(routes),
        LayoutModule
    ],
    providers: [
        {
            provide: LOCALE_ID,
            useValue: "pt-BR"
        }
    ]
})
export class AppModule { }
