module ScfProject.Main

open System
open System.Windows.Forms
open ScfProjectDesign

open TrivialBehind

let mutable res = "";
let mutable resFinal = "";
let mutable difficulty = 0;
let mutable lives = 0;

let generateString len dif =
    let random = new System.Random()
    let mutable generated_code : string = ""
    for i = 1 to len do
        printfn "%s,%d" "i " i
        let key : int = (random.Next(0,dif))
        printfn "%d" key
        generated_code <- generated_code + key.ToString()
    
    printfn "%s" generated_code
    generated_code

let removeChar stringR x =
    let size : int = String.length stringR
    let mutable stringCharRemoved :string = ""
    for i = 0 to size - 1 do
        if(i <> x) then
            stringCharRemoved <- stringCharRemoved + stringR[i].ToString()
    stringCharRemoved

let helpfulAnswerX givenA =
    let size : int = String.length givenA
    let mutable XSigns : string = ""
    for i = 0 to size - 1 do
        if((res.Contains(givenA[i].ToString())) = false) then
            XSigns <- XSigns + "X"
            printfn "%c" givenA[i]
    XSigns

//let helpfulAnswerMinus givenA = 
//    //changing givenA3
//    printfn "%s%s" "Res in minus2 before anything: " res
//    printfn "%s%s" "givenA in minus2 before anything: " givenA
//    let size : int = String.length givenA
//    let mutable minusSigns : string = ""
//    let mutable variable : string = givenA
//    let mutable resultFromGeneratedCode = res
//    let mutable flag = false
//    for i = 0 to size - 1 do
//        for j = 0 to size - 1 do
//            if((givenA[i] = res[j]) && i <> j) then
//                printfn "%c%c%d" givenA[i] res[j] j
//                if(flag = false) then
//                    printfn "%s" "Inside if"
//                    variable <- removeChar givenA i
//                    resultFromGeneratedCode <- removeChar resultFromGeneratedCode j
//                    minusSigns <- minusSigns + "-"
//                    flag <- true
                

//    printfn "%s%s" "var :" variable
//    printfn "%s%s" "resultFromGeneratedCode :" resultFromGeneratedCode
//    res <- resultFromGeneratedCode
//    minusSigns + (helpfulAnswerX variable)
//    //minusSigns

let helpfulAnswerMinus2 givenA = 
    //printfn "%s%s" "Res in minus2 before anything: " res
    //printfn "%s%s" "givenA in minus2 before anything: " givenA
    let mutable minusSigns : string = ""
    let mutable variable : string = givenA
    let mutable varB : string = givenA
    let mutable resultFromGeneratedCode = res

    let mutable flag = false
    let mutable newflag = true
    while(newflag = true) do
        let mutable size : int = String.length variable
        let mutable runCompleted = false;
        //printfn "%s%d" "size: " size
        for i = 0 to size - 1 do
            flag <- false
            if(runCompleted = false) then
                for j = 0 to size - 1 do
                    if((varB[i] = res[j]) && i <> j) then
                        //printfn "%c%c%d" varB[i] res[j] j
                        if(flag = false) then
                            //printfn "%s" "Inside if"
                            variable <- removeChar variable i
                            resultFromGeneratedCode <- removeChar resultFromGeneratedCode j
                            minusSigns <- minusSigns + "-"
                            flag <- true
                            runCompleted <- true
                        //printfn "%s%s%s%s%s" "var :" variable "-----" "resultFromGeneratedCode :" resultFromGeneratedCode
        newflag <- false
        varB <- variable
        res <- resultFromGeneratedCode
        size <- String.length variable
        for i = 0 to size - 1 do
            if((resultFromGeneratedCode.Contains(variable[i].ToString())) = true) then
                printfn "%s%d" "found it at" i
                newflag <- true

    //printfn "%s%s" "var :" variable
    //printfn "%s%s" "resultFromGeneratedCode :" resultFromGeneratedCode
    res <- resultFromGeneratedCode
    minusSigns + (helpfulAnswerX variable)
    //minusSigns

let helpfulAnswerPlus answerInputFromUser =
    //changing givenA2 //done
    let mutable variable : string = answerInputFromUser
    let mutable resultFromGeneratedCode = res
    let mutable plusSigns : string = ""
    let mutable flag = true
    while(flag = true) do
        let size : int = String.length variable
        flag <- false
        let mutable runCompleted = false
        for i = 0 to size - 1 do
            if(runCompleted = false) then
                if(variable[i] = resultFromGeneratedCode[i]) then
                    //printfn "%s%c%c" "PLUS" givenA[i] res[i]
                    variable <- removeChar variable i
                    resultFromGeneratedCode <- removeChar resultFromGeneratedCode i
                    plusSigns <- plusSigns + "+"
                    flag <- true
                    runCompleted <- true

    //printfn "%s%d" "cont: " cont
    printfn "%s%s" "var :" variable
    printfn "%s%s" "resultFromGeneratedCode :" resultFromGeneratedCode
    res <- resultFromGeneratedCode
    printfn "%s%s" "Res after plus :" res
    plusSigns + (helpfulAnswerMinus2 variable)
    //plusSigns


type ScfProjectBehind(ui: ScfProjectUi) = 
    let mutable attempts = 1;
    let mutable contforIF = 1
    do
        ui.button1.Click.Add <| fun _ ->
            if(ui.label2.Text.Equals("easy")) then
                difficulty <- 1
            elif(ui.label2.Text.Equals("intermediate")) then
                difficulty <- 2
            elif(ui.label2.Text.Equals("hard")) then
                difficulty <- 3
            let mutable result = ""
            if(difficulty = 1) then
                result <- (generateString (4) (7))
                lives <- 10
            elif(difficulty = 2) then
                result <- (generateString (5) (8))
                lives <- 15
            elif(difficulty = 3) then
                result <- (generateString (6) (9))
                lives <- 20
    
            res <- result;
            resFinal <- result
            //ui.label1.Text <- difficulty.ToString()
            ui.label2.Text <- "Lives: " + lives.ToString()
            ui.label3.Text <- res
    
    do
    ui.go_bt.Click.Add <| fun _ ->
        
        //ui.try2_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text

        //the most disgusting thing ive done this week:
        if(contforIF = 1)then
            ui.try1_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 2) then
            ui.try2_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 3) then
            ui.try3_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 4) then
            ui.try4_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 5) then
            ui.try5_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 6) then
            ui.try6_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 7) then
            ui.try7_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 8) then
            ui.try8_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 9) then
            ui.try9_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 10) then
            ui.try10_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 11) then
            ui.try11_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 12) then
            ui.try12_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 13) then
            ui.try13_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 14) then
            ui.try14_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 15) then
            ui.try15_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 16) then
            ui.try16_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 17) then
            ui.try17_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 18) then
            ui.try18_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 19) then
            ui.try19_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        elif(contforIF = 20) then
            ui.try20_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text + "\n" + ui.guess_tx.Text
        

        contforIF <- contforIF + 1
        //ui.try2_lb.Text <- helpfulAnswerPlus ui.guess_tx.Text
        if(attempts = lives) then
            ui.label1.Text <- "Out of attempts you lose bro"
            
        if(ui.guess_tx.Text = resFinal) then
            ui.label1.Text <- "Winner Winner chicken dinner"
        
        lives <- lives - 1
        ui.label2.Text <- "Lives: " + lives.ToString()
        res <- resFinal
        

let registerBehinds() =
    TrivialBehinds.RegisterBehind<ScfProjectUi, ScfProjectBehind>()

[<EntryPoint; STAThread>]
let main argv =
    //let mutable result = ""
    //if(difficulty = 1) then
    //    result <- (generateString (4) (7))
    //    lives <- 10
    //elif(difficulty = 2) then
    //    result <- (generateString (5) (8))
    //    lives <- 15
    //elif(difficulty = 3) then
    //    result <- (generateString (6) (9))
    //    lives <- 20
    
    //res <- result;
    //resFinal <- result
    //printf "%s%s" "Result" result
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(false)
    registerBehinds()
    use form = new ScfProjectForm()
    Application.Run(form)  
    0 // return an integer exit code
