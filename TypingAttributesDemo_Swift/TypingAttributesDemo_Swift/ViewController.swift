//
//  ViewController.swift
//  TypingAttributesDemo_Swift
//
//  Created by Admin on 13/05/2019.
//  Copyright © 2019 Admin. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        
        let tf = UITextView();
        assert(tf.typingAttributes != nil);
        assert(tf.typingAttributes.count == 0);
        tf.attributedText = NSAttributedString(string: "some text");
        assert(tf.typingAttributes != nil);
        assert(tf.typingAttributes.count == 1);
    }


}

