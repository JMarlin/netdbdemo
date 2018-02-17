import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'parents',
    templateUrl: './parents.component.html',
    styleUrls: ['./parents.component.css']
})
export class ParentsComponent {
    public parents: Parent[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Parents/Parents').subscribe(result => {
            this.parents = result.json() as Parent[];
        }, error => console.error(error));
    }
}

interface Parent {
    id: number;
    firstName: string;
    lastName: string;
    age: number;
}
