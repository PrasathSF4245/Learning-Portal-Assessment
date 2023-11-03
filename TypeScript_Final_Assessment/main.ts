
class details {
    Title: string;
    Image: string;
    Content: string;
    constructor(title: string, image: string, content: string) {
        this.Title = title;
        this.Image = image;
        this.Content = content;

        console.log("Constructor called");
    }
}
let detailsArray: details[] =
    [
        new details("THE HULK", "url(image/hulk.jpg)", " Dr. Bruce Banner lives a life caught between thesoft-spoken scientist he’s always been and the uncontrollable green monster powered by his rage."),
        new details("Iron Man", "url(image/ironman.jpg)", "After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.After being held captive ."),
        new details("Captian America", "url(image/captian.jpg)", "It is 1942, America has entered World War II, and sickly but determined Steve Rogers is frustrated at being rejected yet again for military service."),
        new details("Thor", "url(image/thor.jpg)", "The son of Odin uses his mighty abilities as the God of Thunder to protect his home Asgard and planet Earth alike. On ScreenIn Comics."),
        new details("Spider Man", "url(image/Spiderman.jpg)", "Spider-Man is a superhero appearing in American comic books published by Marvel Comics. Created by writer-editor Stan Lee and artist Steve Ditko,"),
        new details("Super Man", "url(image/superman.jpg)", "Clark Joseph Kent (né Kal-El), best known by his superhero persona Superman, is a superhero in the DC Extended Universe series of films, based on the DC ..."),
        new details("Bat Man", "url(image/batman.jpg)", "When a sadistic serial killer begins murdering key political figures in Gotham, Batman is forced to investigate the city's hidden corruption and question ..."),
        new details("Hawkeye", "url(image/hawkeye.jpg)", "Series based on the Marvel Comics superhero Hawkeye, centering on the adventures of Young Avenger, Kate Bishop, who took on the role after the original Avenger, ..."),
        new details("Flash", "url(image/flash.jpg)", "Mark Mardon, returns to seek revenge on Joe for the death of Clyde, bearing the same weather-manipulation powers as his deceased sibling"),
        new details("Wolverine", "url(image/wolverine.jpg)", "Wolverine is a character appearing in American comic books published by Marvel Comics, mostly in association with the X-Men. He is a mutant with animal-keen .")

    ];


let i: number = 0;

function next() {
    if (i >= detailsArray.length - 1) {
        i = -1;
    }
    {
        var title: HTMLElement | null = document.getElementById("Title");

        var content: HTMLElement | null = document.getElementById("content");

        if (title && content) {
            i++;
            title.innerHTML = detailsArray[i].Title;
            content.innerHTML = detailsArray[i].Content
            content.style.border = " 2px solid red";


        }
        const body = document.getElementById("body");
        if (body) {
            body.style.backgroundImage = detailsArray[i].Image;
            body.style.backgroundSize = 'cover';
            body.style.backgroundRepeat = 'no-repeat';
        }
    }

}
function before() {
    if (i <= 0) {
        i = detailsArray.length;
    }
    {
        var title: HTMLElement | null = document.getElementById("Title");

        var content: HTMLElement | null = document.getElementById("content");

        if (title && content) {
            i--;
            title.innerHTML = detailsArray[i].Title;
            content.innerHTML = detailsArray[i].Content
            content.style.border = " 2px solid red";
            //  content.style.width="fit-content";

        }
        const body = document.getElementById("body");
        if (body) {
            body.style.backgroundImage = detailsArray[i].Image;
            body.style.backgroundSize = 'cover';
            body.style.backgroundRepeat = 'no-repeat';
        }
    }
}