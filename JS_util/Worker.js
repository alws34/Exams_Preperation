  var arr = [];
  var random;
  var count = 0;
  var doneQuestions;
  var questionsArr;
  var subject;

  function init() {
      localStorage.clear();
      document.getElementById('ph3').innerHTML = count.length + "/" + questionsArr.length;
  }

  function selectsubject() {
      subject = $("#subject").val()

      if (subject != "-1") {
          switch (subject) {
              case "Computational_models":
                  questionsArr = Computational_models;
                  break;
              case "Algoritms":
                  questionsArr = Algoritms;
                  break;
          }
          questionsArr = subject;
      }
  }

  function getRandomArbitrary(min, max) {
      return Math.floor(Math.random() * (max - min) + min);
  }

  function getQuestion() {
      str = "";
      document.getElementById('ph2').innerHTML = "";
      document.getElementById('btnGetAnswer').style.visibility = "visible";
      random;
      if (arr.length == questionsArr.length - 1) {
          arr = [];
          count = 0;
      }

      do {
          flag = true;
          random = getRandomArbitrary(0, questionsArr.length - 1);
          for (var i = 0; i < arr.length; i++) {
              if (random == arr[i])
                  flag = false;
          }
      } while (flag == false);

      str = "<img src='/images/" + subject + "/questions/" + questionsArr[random] + "'>";
      document.getElementById('ph').innerHTML = str;
      arr.push(random);
      count++;
      document.getElementById('ph3').innerHTML = count + "/" + questionsArr.length;
  }

  function getAnswer() {
      str = "<img src='/images/" + subject + "/answers/" + questionsArr[random] + "'>";
      document.getElementById('ph2').innerHTML = str;
      document.getElementById('btnGetAnswer').style.visibility = "hidden";
  }

  //Events
  window.onbeforeunload = function() {
      localStorage.clear();
  };