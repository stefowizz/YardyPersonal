


let slideIndex = 0;
showSlides();

function showSlides() {

    let i;
    let slides = document.getElementsByClassName("mySlides");
    let dots = document.getElementsByClassName("dot");



    for (i = 0; i < slides.length; i++) {

        slides[i].style.display = "none"; 
        let slideIndex = 0;
        showSlides();

        function showSlides() {

            let i;
            let slides = document.getElementsByClassName("mySlides");
            let dots = document.getElementsByClassName("dot");

            for (i = 0; i < slides.length; i++) {

                slides[i].style.display = "none";   

            }

            slideIndex++;

            if (slideIndex > slides.length) {

                slideIndex = 1

            }

            for (i = 0; i < dots.length; i++) {

                dots[i].className = dots[i].className.replace(" active", "");

            }

            slides[slideIndex - 1].style.display = "block";

            dots[slideIndex - 1].className += " active";

            setTimeout(showSlides, 5000); // Image appears every 7 second. 
        }




        var video = document.getElementById("myVideo");
        var btn = document.getElementById("myBtn");

        function myFunction() {

            if (video.paused) {
                video.play();
                //btn.innerHTML = "Pause";
            } else {
                video.pause();
                //btn.innerHTML = "Play";
            }
        }

        //<button id="myBtn" onclick="myFunction()">Pause</button><br /> //place this tag in the INDEX file. 

    } 

} 






//This is a replica of the conditional statement above inside the for loop.




//slideIndex++;

//if (slideIndex > slides.length) {

//slideIndex = 1

//}

//for (i = 0; i < dots.length; i++) {

//dots[i].className = dots[i].className.replace(" active", "");

//}

//slides[slideIndex - 1].style.display = "block";

//dots[slideIndex - 1].className += " active";

//setTimeout(showSlides, 3000); // Change image every 3 seconds

//var video = document.getElementById("myVideo");
//var btn = document.getElementById("myBtn"); 


//<button id="myBtn" onclick="myFunction()">Pause</button><br /> //place this tag in the INDEX file. 
