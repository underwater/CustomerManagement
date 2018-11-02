import { Pipe, PipeTransform } from "@angular/core";

@Pipe({ name: "filter" })
export class FilterPipe implements PipeTransform {
    transform(array: any[], value: string): any[] {
        if (!array) { return []; }
        if (!value) { return array; }
        return array.filter((data) => JSON.stringify(data).toLowerCase().indexOf(value.toLowerCase()) !== -1);
    }
}
