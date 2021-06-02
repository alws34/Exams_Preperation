  var arr = [];
  var random;
  var count = 0;
  var doneQuestions;
  var questionsArr;
  var subject;


  function init() {
      localStorage.clear();
      arrays = {
          "Algorithms": Algorithms_arr,
          "Computational_models": Computational_models_arr
      }
      createDDL();
      //document.getElementById('ph3').innerHTML = count.length + "/" + questionsArr.length;
  }

  function createDDL() {
      keys = Object.keys(arrays);
      let str = ' <option value="-1">please select a subject</option>';
      for (let i = 0; i < keys.length; i++) {
          str += ' <option value="' + keys[i] + '">' + keys[i] + '</option>';

      }
      $('#subjectDDL').html(str);
  }

  function selectsubject() {
      subject = $("#subjectDDL").val()

      if (subject != "-1") { //select subject array (differs in array sizes...)
          questionsArr = arrays[subject];
      }
  }

  function GetIndex(min, max) {
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
          random = GetIndex(0, questionsArr.length - 1);
          for (var i = 0; i < arr.length; i++) {
              if (random == arr[i])
                  flag = false;
          }
      } while (flag == false);
      //str = "<img src='/Exams_prep/images/" + subject + "/questions/" + questionsArr[random] + "'>";
      str = "<img src='/images/" + subject + "/questions/" + questionsArr[random] + "'>";
      document.getElementById('ph').innerHTML = str;
      arr.push(random);
      count++;
      document.getElementById('ph3').innerHTML = count + "/" + questionsArr.length;
  }

  function getAnswer() {
      //str = "<img src='/Exams_prep/images/" + subject + "/answers/" + questionsArr[random] + "'>";
      str = "<img src='/images/" + subject + "/answers/" + questionsArr[random] + "'>";
      document.getElementById('ph2').innerHTML = str;
      document.getElementById('btnGetAnswer').style.visibility = "hidden";
  }

  //Events
  window.onbeforeunload = function() {
      localStorage.clear();
  };